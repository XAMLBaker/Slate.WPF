using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;
using Avalonia.Styling;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Animation.Easings;
using Avalonia.Controls.Presenters;
using Avalonia.Threading;

namespace Slate.Avalonia
{
    public enum TransitionType
    {
        None,
        Fade,
        SlideLeft,
        SlideRight,
        ZoomIn,
        ZoomOut,
        Scale
    }

    public class SlateRegionControl : ContentControl, IStyleable
    {
        public static readonly StyledProperty<object> BindableContentProperty =
            AvaloniaProperty.Register<SlateRegionControl, object>(nameof(BindableContent));

        public object BindableContent
        {
            get => GetValue(BindableContentProperty);
            set => SetValue(BindableContentProperty, value);
        }

        private object _currentVisualContent;

        Type IStyleable.StyleKey => typeof(SlateRegionControl);

        public static readonly StyledProperty<TransitionType> TransitionProperty =
            AvaloniaProperty.Register<SlateRegionControl, TransitionType>(
                nameof(Transition), TransitionType.None);

        public TransitionType Transition
        {
            get => GetValue(TransitionProperty);
            set => SetValue(TransitionProperty, value);
        }

        public static readonly StyledProperty<TimeSpan> TransitionDurationProperty =
            AvaloniaProperty.Register<SlateRegionControl, TimeSpan>(
                nameof(TransitionDuration), TimeSpan.FromMilliseconds(300));

        public TimeSpan TransitionDuration
        {
            get => GetValue(TransitionDurationProperty);
            set => SetValue(TransitionDurationProperty, value);
        }

        public static readonly StyledProperty<bool> IsReverseProperty =
            AvaloniaProperty.Register<SlateRegionControl, bool>(
                nameof(IsReverse), false);

        public bool IsReverse
        {
            get => GetValue(IsReverseProperty);
            set => SetValue(IsReverseProperty, value);
        }

        public static readonly StyledProperty<string> RegionNameProperty =
            AvaloniaProperty.Register<SlateRegionControl, string>(
                nameof(RegionName), defaultValue: null);


        public string RegionName
        {
            get => GetValue(RegionNameProperty);
            set => SetValue(RegionNameProperty, value);
        }

        static SlateRegionControl()
        {
            RegionNameProperty.Changed.AddClassHandler<SlateRegionControl>((ctrl, e) =>
            {
                if (e.NewValue == null)
                    return;
                if (!string.IsNullOrWhiteSpace(e.NewValue.ToString()))
                {
                    RegionManager.RegisterRegion(e.NewValue.ToString(), ctrl);
                }
            });
        }

        private object _previousContent;

        public SlateRegionControl()
        {
            this.GetObservable(BindableContentProperty)
                .Subscribe(async newContent =>
                {
                    var oldContent = _previousContent;
                    _previousContent = newContent;
                    await TransitionAsync(oldContent, newContent);
                });
        }

        // protected override async void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        // {
        //     base.OnPropertyChanged(change);
        //     if (change.Property.Name == nameof(Content))
        //     {
        //         await TransitionAsync(change.OldValue, change.NewValue);
        //     }
        // }

        private ContentPresenter? _oldPresenter;
        private ContentPresenter? _newPresenter;
        private Grid? _rootGrid;
        private CancellationTokenSource _cts = new();

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            _rootGrid = e.NameScope.Find<Grid>("PART_RootGrid");
            _oldPresenter = e.NameScope.Find<ContentPresenter>("PART_OldContent");
            _newPresenter = e.NameScope.Find<ContentPresenter>("PART_NewContent");

            if (_oldPresenter == null || _newPresenter == null)
                throw new InvalidOperationException("PART_OldContent, PART_NewContent가 필요합니다.");

            _newPresenter.Content = Content;
            _oldPresenter.IsVisible = false;
        }

        private async Task TransitionAsync(object? oldContent, object? newContent)
        {
            if (_rootGrid == null || _oldPresenter == null || _newPresenter == null)
                return;
            _cts.Cancel();
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Dispatcher.UIThread.Invoke(async () =>
            {
                // 기존 부모에서 제거 (필수! WPF는 동시에 하나의 부모만 허용)
               
                _oldPresenter.Content = null;
                _newPresenter.Content = null;
                _oldPresenter.Content = oldContent;
                _newPresenter.Content = newContent;
                _oldPresenter.IsVisible = true;
                _newPresenter.IsVisible = true;

                ResetTransforms(_oldPresenter);
                ResetTransforms(_newPresenter);

                var duration = TransitionDuration;

               
                _oldPresenter.ZIndex = 0;
                _newPresenter.ZIndex = 1;
                switch (Transition)
                {
                    case TransitionType.Fade:
                        var oldAnim = Ani(BaseAnimation(duration), FadeKeyFrame(0.0, 1.0), FadeKeyFrame(1.0, 0.0)).RunAsync(_oldPresenter); 
                        var newAnim = Ani(BaseAnimation(duration), FadeKeyFrame(0.0, 0.0),FadeKeyFrame(1.0, 1.0)).RunAsync(_newPresenter);
                        await Task.WhenAll(oldAnim, newAnim);
                        break;
                    //
                    case TransitionType.SlideLeft:
                        var oldAnim1 = Ani(BaseAnimation(duration), TranslateTransformXFrame(0.0, 0.0), TranslateTransformXFrame(1.0, -_rootGrid.Bounds.Width)).RunAsync(_oldPresenter); 
                        var newAnim2 = Ani(BaseAnimation(duration), TranslateTransformXFrame(0.0, _rootGrid.Bounds.Width), TranslateTransformXFrame(1.0, 0.0)).RunAsync(_newPresenter);
                        
                        await Task.WhenAll(oldAnim1, newAnim2);
                        break;
                    
                    case TransitionType.SlideRight:
                        var oldAnim3 = Ani(BaseAnimation(duration), TranslateTransformXFrame(0.0, 0.0), TranslateTransformXFrame(1.0, _rootGrid.Bounds.Width)).RunAsync(_oldPresenter); 
                        var newAnim4 = Ani(BaseAnimation(duration), TranslateTransformXFrame(0.0, -_rootGrid.Bounds.Width), TranslateTransformXFrame(1.0, 0.0)).RunAsync(_newPresenter);
                        
                        await Task.WhenAll(oldAnim3, newAnim4);
                        break;
                    
                    case TransitionType.ZoomIn:
                        await Ani(BaseAnimation(duration), ScaleXKeyFrame(0.0, 0.0), ScaleXKeyFrame(1.0, 1.0), 
                                                                       ScaleYKeyFrame(0.0, 0.0), ScaleYKeyFrame(0.0, 1.0),
                                                                                     FadeKeyFrame(0.0,0.0),
                                                                                     FadeKeyFrame(1.0,1.0)
                                                                                    ).RunAsync(_newPresenter);
                        
                        break;
                    case TransitionType.ZoomOut:
                        _oldPresenter.ZIndex = 1;
                        _newPresenter.ZIndex = 0;
                        await Ani(BaseAnimation(duration), 
                            ScaleXKeyFrame(0.0, 1.0), ScaleXKeyFrame(1.0, 0.0), 
                                        ScaleYKeyFrame(0.0, 1.0), ScaleYKeyFrame(0.0, 0.0), 
                                        FadeKeyFrame(0.0,1.0), FadeKeyFrame(1.0,0.0)
                        ).RunAsync(_oldPresenter);
                        break;
                    case TransitionType.None:
                    default:
                        _oldPresenter.IsVisible = false;
                        return;
                }

// 공통 후처리
            });
        }
        private Animation Ani(Animation ani, params KeyFrame[] children)
        {
            foreach (var child in children)
            {
                ani.Children.Add(child);
            }
            return ani;
        }
        private Animation BaseAnimation(TimeSpan duration)
        {
            var anim = new Animation
            {
                Duration = duration,
            };
            return anim;
        }
        
        private KeyFrame FadeKeyFrame(double percent, double value)
        {
            return new KeyFrame
            {
                Cue = new Cue(percent),
                Setters = { new Setter(Visual.OpacityProperty, value) },
            };
        }
        private KeyFrame TranslateTransformXFrame(double percent, double value)
        {
            return new KeyFrame
            {
                Cue = new Cue(percent),
                Setters = { new Setter(TranslateTransform.XProperty, value) },
            };
        }
        private KeyFrame ScaleXKeyFrame(double percent, double value)
        {
            return new KeyFrame
            {
                Cue = new Cue(percent),
                Setters = { new Setter(ScaleTransform.ScaleXProperty, value) },
            };
        }
        private KeyFrame ScaleYKeyFrame(double percent, double value)
        {
            return new KeyFrame
            {
                Cue = new Cue(percent),
                Setters = { new Setter(ScaleTransform.ScaleYProperty, value) },
            };
        }
        private void ResetTransforms(Control presenter)
        {
            presenter.RenderTransform = new TransformGroup
            {
                Children = new Transforms
                {
                    new TranslateTransform { X = 0, Y = 0 },
                    new ScaleTransform { ScaleX = 1, ScaleY = 1 }
                }
            };
        }

        public void RegisterControl<T>()
        {
            var element = RegisterProvider.Get<T>() as Control;
            if (element != null)
                RegionManager.Attach(this.RegionName, element);
        }

        public void Set() => RegionManager.Attach(this.RegionName, this);
        public void DSet() => RegionManager.Detach(this.RegionName);
    }

    public static class RegionControlExtensions
    {
        public static SlateRegionControl BindingControl<T>(this SlateRegionControl control)
        {
            control.RegisterControl<T>();
            return control;
        }
    }
}