namespace Slate.MAUI
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
    public class SlateRegionControl : ContentView
    {
        public static readonly BindableProperty TransitionProperty =
            BindableProperty.Create (nameof (Transition), typeof (TransitionType), typeof (SlateRegionControl), TransitionType.None);

        public TransitionType Transition
        {
            get => (TransitionType)GetValue (TransitionProperty);
            set => SetValue (TransitionProperty, value);
        }

        public static readonly BindableProperty TransitionDurationProperty =
            BindableProperty.Create (nameof (TransitionDuration), typeof (uint), typeof (SlateRegionControl), 300u);

        public uint TransitionDuration
        {
            get => (uint)GetValue (TransitionDurationProperty);
            set => SetValue (TransitionDurationProperty, value);
        }

        public static readonly BindableProperty RegionNameProperty =
            BindableProperty.Create (nameof (RegionName), typeof (string), typeof (SlateRegionControl), null, propertyChanged: OnRegionNameChanged);

        public string RegionName
        {
            get => (string)GetValue (RegionNameProperty);
            set => SetValue (RegionNameProperty, value);
        }

        private static void OnRegionNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SlateRegionControl control && newValue is string name)
            {
                RegionManager.RegisterRegion (name, control);
            }
        }

        private View _oldContent;
        private View _newContent;
        private CancellationTokenSource _cts = new ();
        private ContentView content;

        protected override async void OnBindingContextChanged()
        {
            base.OnBindingContextChanged ();
            await TransitionAsync (_oldContent, Content as View);
        }

        protected override async void OnParentSet()
        {
            base.OnParentSet ();
            _oldContent = null;
            _newContent = Content as View;
        }

        protected override async void OnChildAdded(Element child)
        {
            base.OnChildAdded (child);
            await TransitionAsync (_oldContent, child as View);
            _oldContent = child as View;
        }

        private async Task TransitionAsync(View oldView, View newView)
        {
            if (oldView == null || newView == null)
            {
                Content = newView;
                return;
            }

            _cts.Cancel ();
            _cts = new ();
            var token = _cts.Token;

            var duration = TransitionDuration;

            // 준비
            newView.Opacity = 0;
            if (Transition == TransitionType.SlideLeft || Transition == TransitionType.SlideRight)
                newView.TranslationX = Transition == TransitionType.SlideLeft ? Width : -Width;
            else if (Transition == TransitionType.ZoomIn || Transition == TransitionType.Scale)
                newView.Scale = 0;

            Content = newView;

            // 애니메이션 동시 실행
            var animations = new Task[]
            {
                AnimateOldView(oldView, duration),
                AnimateNewView(newView, duration)
            };

            await Task.WhenAll (animations);
        }

        private Task AnimateOldView(View view, uint duration)
        {
            switch (Transition)
            {
                case TransitionType.Fade:
                    return view.FadeTo (0, duration);
                case TransitionType.SlideLeft:
                    return view.TranslateTo (-Width, 0, duration);
                case TransitionType.SlideRight:
                    return view.TranslateTo (Width, 0, duration);
                case TransitionType.ZoomOut:
                case TransitionType.Scale:
                    return view.ScaleTo (0, duration);
                default:
                    return Task.CompletedTask;
            }
        }

        private Task AnimateNewView(View view, uint duration)
        {
            switch (Transition)
            {
                case TransitionType.Fade:
                    return view.FadeTo (1, duration);
                case TransitionType.SlideLeft:
                case TransitionType.SlideRight:
                    return view.TranslateTo (0, 0, duration);
                case TransitionType.ZoomIn:
                case TransitionType.Scale:
                    return view.ScaleTo (1, duration);
                default:
                    return view.FadeTo (1, duration);
            }
        }
    }
}
