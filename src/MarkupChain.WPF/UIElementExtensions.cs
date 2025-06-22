namespace MarkupChain.WPF
{
    public static partial class UIElementExtensions
    {
        public static T AllowDrop<T>(this T element, bool allowDrop) where T : UIElement
        {
            element.SetValue (UIElement.AllowDropProperty, allowDrop);
            return element;
        }
        public static T Opacity<T>(this T element, double opacity) where T : UIElement
        {
            element.SetValue (UIElement.OpacityProperty, opacity);
            return element;
        }

        public static T Visibility<T>(this T element, Visibility visibility) where T : UIElement
        {
            element.SetValue (UIElement.VisibilityProperty, visibility);
            return element;
        }

        public static T Uid<T>(this T element, string uid) where T : UIElement
        {
            element.SetValue (UIElement.UidProperty, uid);
            return element;
        }
        public static T OpacityMask<T>(this T element, Brush opacityMask) where T : UIElement
        {
            element.SetValue (UIElement.OpacityMaskProperty, opacityMask);
            return element;
        }
        public static T SnapsToDevicePixels<T>(this T element, bool snapsToDevicePixels) where T : UIElement
        {
            element.SetValue (UIElement.SnapsToDevicePixelsProperty, snapsToDevicePixels);
            return element;
        }
        public static T RenderTransform<T>(this T element, Transform renderTransform) where T : UIElement
        {
            element.SetValue (UIElement.RenderTransformProperty, renderTransform);
            return element;
        }
        public static T RenderTransformOrigin<T>(this T element, Point renderTransformOrigin) where T : UIElement
        {
            element.SetValue (UIElement.RenderTransformOriginProperty, renderTransformOrigin);
            return element;
        }

        public static T IsKeyboardFocusWithin<T>(this T element, bool isKeyboardFocusWithin) where T : UIElement
        {
            element.SetValue (UIElement.IsKeyboardFocusWithinProperty, isKeyboardFocusWithin);
            return element;
        }
        public static T IsKeyboardFocused<T>(this T element, bool isKeyboardFocused) where T : UIElement
        {
            element.SetValue (UIElement.IsKeyboardFocusedProperty, isKeyboardFocused);
            return element;
        }

        public static T IsHitTestVisible<T>(this T element, bool isHitTestVisible) where T : UIElement
        {
            element.SetValue (UIElement.IsHitTestVisibleProperty, isHitTestVisible);
            return element;
        }

        public static T IsFocused<T>(this T element, bool isFocused) where T : UIElement
        {
            element.SetValue (UIElement.IsFocusedProperty, isFocused);
            return element;
        }
        public static T IsEnabled<T>(this T element, bool isEnabled) where T : UIElement
        {
            element.SetValue (UIElement.IsEnabledProperty, isEnabled);
            return element;
        }

        public static T Focusable<T>(this T element, bool focusable) where T : UIElement
        {
            element.SetValue (UIElement.FocusableProperty, focusable);
            return element;
        }

        public static T IsManipulationEnabled<T>(this T element, bool isManipulationEnabled) where T : UIElement
        {
            element.SetValue (UIElement.IsManipulationEnabledProperty, isManipulationEnabled);
            return element;
        }
        public static T ClipToBounds<T>(this T element, bool clipToBounds) where T : UIElement
        {
            element.SetValue (UIElement.ClipToBoundsProperty, clipToBounds);
            return element;
        }

        public static T Clip<T>(this T element, Geometry clip) where T : UIElement
        {
            element.SetValue (UIElement.ClipProperty, clip);
            return element;
        }

        public static T AreAnyTouchesOver<T>(this T element, bool areAnyTouchesOver) where T : UIElement
        {
            element.SetValue (UIElement.AreAnyTouchesOverProperty, areAnyTouchesOver);
            return element;
        }

        public static T AreAnyTouchesDirectlyOver<T>(this T element, bool areAnyTouchesDirectlyOver) where T : UIElement
        {
            element.SetValue (UIElement.AreAnyTouchesDirectlyOverProperty, areAnyTouchesDirectlyOver);
            return element;
        }

        public static T AreAnyTouchesCapturedWithin<T>(this T element, bool areAnyTouchesCapturedWithin) where T : UIElement
        {
            element.SetValue (UIElement.AreAnyTouchesCapturedWithinProperty, areAnyTouchesCapturedWithin);
            return element;
        }

        public static T AreAnyTouchesCaptured<T>(this T element, bool areAnyTouchesCaptured) where T : UIElement
        {
            element.SetValue (UIElement.AreAnyTouchesCapturedProperty, areAnyTouchesCaptured);
            return element;
        }

        public static T IsMouseCaptured<T>(this T element, bool isMouseCaptured) where T : UIElement
        {
            element.SetValue (UIElement.IsMouseCapturedProperty, isMouseCaptured);
            return element;
        }

        public static T CacheMode<T>(this T element, CacheMode cacheMode) where T : UIElement
        {
            element.SetValue (UIElement.CacheModeProperty, cacheMode);
            return element;
        }

        public static T IsMouseDirectlyOver<T>(this T element, bool isMouseDirectlyOver) where T : UIElement
        {
            element.SetValue (UIElement.IsMouseDirectlyOverProperty, isMouseDirectlyOver);
            return element;
        }

        public static T IsMouseCaptureWithin<T>(this T element, bool isMouseCaptureWithin) where T : UIElement
        {
            element.SetValue (UIElement.IsMouseCaptureWithinProperty, isMouseCaptureWithin);
            return element;
        }

        public static T IsStylusCaptured<T>(this T element, bool isStylusCaptured) where T : UIElement
        {
            element.SetValue (UIElement.IsStylusCapturedProperty, isStylusCaptured);
            return element;
        }

        public static T IsMouseOver<T>(this T element, bool isMouseOver) where T : UIElement
        {
            element.SetValue (UIElement.IsMouseOverProperty, isMouseOver);
            return element;
        }

        public static T IsStylusDirectlyOver<T>(this T element, bool isStylusDirectlyOver) where T : UIElement
        {
            element.SetValue (UIElement.IsStylusDirectlyOverProperty, isStylusDirectlyOver);
            return element;
        }

        public static T IsStylusOver<T>(this T element, bool isStylusOver) where T : UIElement
        {
            element.SetValue (UIElement.IsStylusOverProperty, isStylusOver);
            return element;
        }

        public static T IsStylusCaptureWithin<T>(this T element, bool isStylusCaptureWithin) where T : UIElement
        {
            element.SetValue (UIElement.IsStylusCaptureWithinProperty, isStylusCaptureWithin);
            return element;
        }

        public static T IsVisible<T>(this T element, bool isVisible) where T : UIElement
        {
            element.SetValue (UIElement.IsVisibleProperty, isVisible);
            return element;
        }
    }
}
