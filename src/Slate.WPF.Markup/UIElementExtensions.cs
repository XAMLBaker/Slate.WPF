using System.Windows.Data;

namespace Slate.WPF.Markup
{
    public static partial class UIElementExtensions
    {
        public static T AllowDrop<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.AllowDropProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T Opacity<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.OpacityProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T Visibility<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.VisibilityProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T Uid<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.UidProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T OpacityMask<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.OpacityMaskProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T SnapsToDevicePixels<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.SnapsToDevicePixelsProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T RenderTransform<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.RenderTransformProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T RenderTransformOrigin<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.RenderTransformOriginProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsKeyboardFocusWithin<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsKeyboardFocusWithinProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T IsKeyboardFocused<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsKeyboardFocusedProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsHitTestVisible<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsHitTestVisibleProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsFocused<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsFocusedProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T IsEnabled<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsEnabledProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T Focusable<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.FocusableProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsManipulationEnabled<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsManipulationEnabledProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
        public static T ClipToBounds<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.ClipToBoundsProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T Clip<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.ClipProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T AreAnyTouchesOver<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.AreAnyTouchesOverProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T AreAnyTouchesDirectlyOver<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.AreAnyTouchesDirectlyOverProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T AreAnyTouchesCapturedWithin<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.AreAnyTouchesCapturedWithinProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T AreAnyTouchesCaptured<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.AreAnyTouchesCapturedProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsMouseCaptured<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsMouseCapturedProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T CacheMode<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.CacheModeProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsMouseDirectlyOver<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsMouseDirectlyOverProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsMouseCaptureWithin<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsMouseCaptureWithinProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsStylusCaptured<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsStylusCapturedProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsMouseOver<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsMouseOverProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsStylusDirectlyOver<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsStylusDirectlyOverProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsStylusOver<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsStylusOverProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsStylusCaptureWithin<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsStylusCaptureWithinProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }

        public static T IsVisible<T>(this T element, IState state) where T : UIElement
        {
            BindingOperations.SetBinding (element, UIElement.IsVisibleProperty, new Binding ("Value")
            {
                Source = state,
            });
            return element;
        }
    }
}
