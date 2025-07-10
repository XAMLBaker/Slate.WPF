using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using System;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
namespace Slate.WinUI3
{
    public enum TransitionType
    {
        None,       // 🔹 노멀 모드
        Fade,
        SlideLeft,
        SlideRight,
        ZoomIn,
        ZoomOut,
        Scale
    }
    public class SlateRegionControl : ContentControl
    {
        public static readonly DependencyProperty TransitionProperty =
            DependencyProperty.Register (nameof (Transition), typeof (TransitionType), typeof (SlateRegionControl),
                new PropertyMetadata (TransitionType.None));

        public TransitionType Transition
        {
            get => (TransitionType)GetValue (TransitionProperty);
            set => SetValue (TransitionProperty, value);
        }

        public static readonly DependencyProperty TransitionDurationProperty =
            DependencyProperty.Register (nameof (TransitionDuration), typeof (TimeSpan), typeof (SlateRegionControl),
                new PropertyMetadata (TimeSpan.FromMilliseconds (300)));

        public TimeSpan TransitionDuration
        {
            get => (TimeSpan)GetValue (TransitionDurationProperty);
            set => SetValue (TransitionDurationProperty, value);
        }

        public static readonly DependencyProperty IsReverseProperty =
            DependencyProperty.Register (nameof (IsReverse), typeof (bool), typeof (SlateRegionControl),
                new PropertyMetadata (false));

        public bool IsReverse
        {
            get => (bool)GetValue (IsReverseProperty);
            set => SetValue (IsReverseProperty, value);
        }

        public string RegionName
        {
            get => (string)GetValue (RegionNameProperty);
            set => SetValue (RegionNameProperty, value);
        }

        public static readonly DependencyProperty RegionNameProperty =
            DependencyProperty.Register (nameof (RegionName), typeof (string), typeof (SlateRegionControl),
                new PropertyMetadata (null, OnRegionNameChanged));

        private static void OnRegionNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is SlateRegionControl host && e.NewValue is string newName)
            {
                RegionManager.RegisterRegion (newName, host);
            }
        }

        public SlateRegionControl()
        {
            this.DefaultStyleKey = typeof (SlateRegionControl);
        }

        public SlateRegionControl(string regionName) : this ()
        {
            this.RegionName = regionName;
        }

        private ContentPresenter _newPresenter;
        private ContentPresenter _oldPresenter;

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate ();

            _oldPresenter = GetTemplateChild ("PART_OldContent") as ContentPresenter;
            _newPresenter = GetTemplateChild ("PART_NewContent") as ContentPresenter;

            if (_oldPresenter == null || _newPresenter == null)
                throw new InvalidOperationException ("PART_OldContent, PART_NewContent가 필요합니다.");
          
            _newPresenter.Content = Content;
            _oldPresenter.Visibility = Visibility.Collapsed;
            _oldPresenter.Opacity = 1;
            _oldPresenter.RenderTransform = new TranslateTransform { X = 0, Y = 0 };

            _newPresenter.Visibility = Visibility.Visible;
            _newPresenter.Opacity = 1;
            _newPresenter.RenderTransform = new TranslateTransform { X = 0, Y = 0 };

        }

        private UIElement element;
        public void RegisterControl<T>()
        {
            element = (UIElement)RegisterProvider.Get<T> ();
            RegionManager.Attach (this.RegionName, element);
        }

        public void Set() => RegionManager.Attach (this.RegionName, element);

        public void DSet() => RegionManager.Detach (this.RegionName);

        private CancellationTokenSource _cts = new ();

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged (oldContent, newContent);
            _ = TransitionAsync (oldContent, newContent);
        }

        private async Task TransitionAsync(object oldContent, object newContent)
        {
            if (_oldPresenter == null || _newPresenter == null)
            {
                return;
            }

            _cts.Cancel ();
            _cts = new CancellationTokenSource ();
            var token = _cts.Token;

            _oldPresenter.Content = oldContent;
            _newPresenter.Content = newContent;

            _oldPresenter.Visibility = Visibility.Visible;
            _newPresenter.Visibility = Visibility.Visible;

            ResetTransforms (_oldPresenter);
            ResetTransforms (_newPresenter);

            var duration = TransitionDuration;
            var tcs = new TaskCompletionSource ();

            var sb = new Storyboard ();
            sb.Completed += (_, __) =>
            {
                _oldPresenter.Content = null;
                _oldPresenter.Visibility = Visibility.Collapsed;
                if (!token.IsCancellationRequested)
                    tcs.SetResult ();
            };

            Canvas.SetZIndex (_oldPresenter, 0);
            Canvas.SetZIndex (_newPresenter, 1);

            switch (Transition)
            {
                case TransitionType.Fade:
                    AddFadeAnimation (sb, _oldPresenter, 1, 0, duration);
                    AddFadeAnimation (sb, _newPresenter, 0, 1, duration);
                    break;
                case TransitionType.SlideLeft:
                    AddSlideAnimation (sb, _oldPresenter, 0, -ActualWidth, duration);
                    AddSlideAnimation (sb, _newPresenter, ActualWidth, 0, duration);
                    break;
                case TransitionType.SlideRight:
                    AddSlideAnimation (sb, _oldPresenter, 0, ActualWidth, duration);
                    AddSlideAnimation (sb, _newPresenter, -ActualWidth, 0, duration);
                    break;
                case TransitionType.ZoomIn:
                    AddZoomAnimation (sb, _newPresenter, 0, 1, duration);
                    AddFadeAnimation (sb, _newPresenter, 0, 1, duration);
                    break;
                case TransitionType.ZoomOut:
                    Canvas.SetZIndex (_oldPresenter, 1);
                    Canvas.SetZIndex (_newPresenter, 0);
                    AddZoomAnimation (sb, _oldPresenter, 1, 0.8, duration);
                    AddFadeAnimation (sb, _oldPresenter, 1, 0, duration);
                    break;
                case TransitionType.Scale:
                    AddZoomAnimation (sb, _oldPresenter, 1, 0, duration);
                    AddZoomAnimation (sb, _newPresenter, 0, 1, duration);
                    break;
                case TransitionType.None:
                default:
                    _oldPresenter.Content = null;
                    _oldPresenter.Visibility = Visibility.Collapsed;
                    return;
            }

            sb.Begin ();
            await tcs.Task;
        }

        private void ResetTransforms(ContentPresenter presenter)
        {
            if (presenter.RenderTransform is TranslateTransform translate)
            {
                translate.X = 0;
                translate.Y = 0;
            }
            if (presenter.RenderTransform is ScaleTransform scale)
            {
                scale.ScaleX = 1;
                scale.ScaleY = 1;
            }
            presenter.RenderTransformOrigin = new Point (0.5, 0.5);
        }

        private void AddFadeAnimation(Storyboard sb, UIElement target, double from, double to, TimeSpan duration)
        {
            var anim = new DoubleAnimation { From = from, To = to, Duration = new Duration (duration) };
            Storyboard.SetTarget (anim, target);
            Storyboard.SetTargetProperty (anim, "Opacity");
            sb.Children.Add (anim);
        }

        private void AddSlideAnimation(Storyboard sb, UIElement target, double fromX, double toX, TimeSpan duration)
        {
            target.RenderTransformOrigin = new Point (0.5, 0.5);
            target.RenderTransform = new TranslateTransform ();
            target.Opacity = 1;
            target.Visibility = Visibility.Visible;

            var anim = new DoubleAnimation { From = fromX, To = toX, Duration = new Duration (duration) };
            Storyboard.SetTarget (anim, target);
            Storyboard.SetTargetProperty (anim, "(UIElement.RenderTransform).(TranslateTransform.X)");
            sb.Children.Add (anim);
        }

        private void AddZoomAnimation(Storyboard sb, UIElement target, double fromScale, double toScale, TimeSpan duration)
        {
            target.RenderTransformOrigin = new Point (0.5, 0.5);
            target.RenderTransform = new ScaleTransform { ScaleX = fromScale, ScaleY = fromScale };

            var animX = new DoubleAnimation { From = fromScale, To = toScale, Duration = new Duration (duration) };
            var animY = new DoubleAnimation { From = fromScale, To = toScale, Duration = new Duration (duration) };

            Storyboard.SetTarget (animX, target);
            Storyboard.SetTargetProperty (animX, "(UIElement.RenderTransform).(ScaleTransform.ScaleX)");

            Storyboard.SetTarget (animY, target);
            Storyboard.SetTargetProperty (animY, "(UIElement.RenderTransform).(ScaleTransform.ScaleY)");

            sb.Children.Add (animX);
            sb.Children.Add (animY);
        }
    }

    public static class RegionControlExtensions
    {
        public static SlateRegionControl BindingControl<T>(this SlateRegionControl control)
        {
            control.RegisterControl<T> ();
            return control;
        }
    }
}
