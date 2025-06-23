
namespace MarkupChain.WinUI3;

public static class UIElementExtensions
{
    public static T AccessKey<T>(this T element, string accessKey) where T : UIElement
    {
        element.SetValue(UIElement.AccessKeyProperty, accessKey);
        return element;
    }

    public static T AccessKeyScopeOwner<T>(this T element, DependencyObject accessKeyScopeOwner) where T : UIElement
    {
        element.SetValue(UIElement.AccessKeyScopeOwnerProperty, accessKeyScopeOwner);
        return element;
    }

    public static T AllowDrop<T>(this T element, bool allowDrop) where T : UIElement
    {
        element.SetValue(UIElement.AllowDropProperty, allowDrop);
        return element;
    }

    public static T CacheMode<T>(this T element, CacheMode cacheMode) where T : UIElement
    {
        element.SetValue(UIElement.CacheModeProperty, cacheMode);
        return element;
    }

    public static T CanBeScrollAnchor<T>(this T element, bool canBeScrollAnchor) where T : UIElement
    {
        element.SetValue(UIElement.CanBeScrollAnchorProperty, canBeScrollAnchor);
        return element;
    }

    public static T CanDrag<T>(this T element, bool canDrag) where T : UIElement
    {
        element.SetValue(UIElement.CanDragProperty, canDrag);
        return element;
    }

    public static T Clip<T>(this T element, Geometry clip) where T : UIElement
    {
        element.SetValue(UIElement.ClipProperty, clip);
        return element;
    }

    public static T CompositeMode<T>(this T element, ElementCompositeMode compositeMode) where T : UIElement
    {
        element.SetValue(UIElement.CompositeModeProperty, compositeMode);
        return element;
    }

    public static T ContextFlyout<T>(this T element, FlyoutBase contextFlyout) where T : UIElement
    {
        element.SetValue(UIElement.ContextFlyoutProperty, contextFlyout);
        return element;
    }

    public static T FocusState<T>(this T element, FocusState focusState) where T : UIElement
    {
        element.SetValue(UIElement.FocusStateProperty, focusState);
        return element;
    }

    public static T HighContrastAdjustment<T>(this T element, ElementHighContrastAdjustment highContrastAdjustment)
        where T : UIElement
    {
        element.SetValue(UIElement.HighContrastAdjustmentProperty, highContrastAdjustment);
        return element;
    }

    public static T IsAccessKeyScope<T>(this T element, bool isAccessKeyScope) where T : UIElement
    {
        element.SetValue(UIElement.IsAccessKeyScopeProperty, isAccessKeyScope);
        return element;
    }
    public static T IsDoubleTapEnabled<T>(this T element, bool isDoubleTapEnabled) where T : UIElement
    {
        element.SetValue(UIElement.IsDoubleTapEnabledProperty, isDoubleTapEnabled);
        return element;
    }

    public static T IsHitTestVisible<T>(this T element, bool isHitTestVisible) where T : UIElement
    {
        element.SetValue(UIElement.IsHitTestVisibleProperty, isHitTestVisible);
        return element;
    }

    public static T IsHoldingEnabled<T>(this T element, bool isHoldingEnabled) where T : UIElement
    {
        element.SetValue(UIElement.IsHoldingEnabledProperty, isHoldingEnabled);
        return element;
    }


    public static T IsRightTapEnabled<T>(this T element, bool isRightTapEnabled) where T : UIElement
    {
        element.SetValue(UIElement.IsRightTapEnabledProperty, isRightTapEnabled);
        return element;
    }

    public static T IsTabStop<T>(this T element, bool isTabStop) where T : UIElement
    {
        element.SetValue(UIElement.IsTabStopProperty, isTabStop);
        return element;
    }

    public static T IsTapEnabled<T>(this T element, bool isTapEnabled) where T : UIElement
    {
        element.SetValue(UIElement.IsTapEnabledProperty, isTapEnabled);
        return element;
    }

    public static T KeyboardAcceleratorPlacementMode<T>(this T element, KeyboardAcceleratorPlacementMode placementMode) where T : UIElement
    {
        element.SetValue(UIElement.KeyboardAcceleratorPlacementModeProperty, placementMode);
        return element;
    }

    public static T KeyboardAcceleratorPlacementTarget<T>(this T element, DependencyObject target) where T : UIElement
    {
        element.SetValue(UIElement.KeyboardAcceleratorPlacementTargetProperty, target);
        return element;
    }

    public static T KeyTipHorizontalOffset<T>(this T element, double keyTipHorizontalOffset) where T : UIElement
    {
        element.SetValue(UIElement.KeyTipHorizontalOffsetProperty, keyTipHorizontalOffset);
        return element;
    }

    public static T KeyTipPlacementMode<T>(this T element, KeyTipPlacementMode placementMode) where T : UIElement
    {
        element.SetValue(UIElement.KeyTipPlacementModeProperty, placementMode);
        return element;
    }

    public static T KeyTipTarget<T>(this T element, DependencyObject keyTipTarget) where T : UIElement
    {
        element.SetValue(UIElement.KeyTipTargetProperty, keyTipTarget);
        return element;
    }

    public static T KeyTipVerticalOffset<T>(this T element, double keyTipVerticalOffset) where T : UIElement
    {
        element.SetValue(UIElement.KeyTipVerticalOffsetProperty, keyTipVerticalOffset);
        return element;
    }


    public static T Lights<T>(this T element, IList<XamlLight> lights) where T : UIElement
    {
        element.SetValue(UIElement.LightsProperty, lights);
        return element;
    }


    public static T ManipulationMode<T>(this T element, ManipulationModes manipulationMode) where T : UIElement
    {
        element.SetValue(UIElement.ManipulationModeProperty, manipulationMode);
        return element;
    }


    public static T Opacity<T>(this T element, double opacity) where T : UIElement
    {
        element.SetValue(UIElement.OpacityProperty, opacity);
        return element;
    }

    public static T PointerCaptures<T>(this T element, IList<Pointer> pointerCaptures) where T : UIElement
    {
        element.SetValue(UIElement.PointerCapturesProperty, pointerCaptures);
        return element;
    }

    public static T Projection<T>(this T element, PlaneProjection projection) where T : UIElement
    {
        element.SetValue(UIElement.ProjectionProperty, projection);
        return element;
    }

    public static T RenderTransformOrigin<T>(this T element, Windows.Foundation.Point renderTransformOrigin) where T : UIElement
    {
        element.SetValue(UIElement.RenderTransformOriginProperty, renderTransformOrigin);
        return element;
    }

    public static T RenderTransform<T>(this T element, Transform renderTransform) where T : UIElement
    {
        element.SetValue(UIElement.RenderTransformProperty, renderTransform);
        return element;
    }

    public static T Shadow<T>(this T element, Shadow shadow) where T : UIElement
    {
        element.SetValue(UIElement.ShadowProperty, shadow);
        return element;
    }

    public static T TabFocusNavigation<T>(this T element, KeyboardNavigationMode tabFocusNavigation) where T : UIElement
    {
        element.SetValue(UIElement.TabFocusNavigationProperty, tabFocusNavigation);
        return element;
    }

    public static T UseLayoutRounding<T>(this T element, bool useLayoutRounding) where T : UIElement
    {
        element.SetValue(UIElement.UseLayoutRoundingProperty, useLayoutRounding);
        return element;
    }

    public static T Visibility<T>(this T element, Visibility visibility) where T : UIElement
    {
        element.SetValue(UIElement.VisibilityProperty, visibility);
        return element;
    }

    public static T XYFocusDownNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy) where T : UIElement
    {
        element.SetValue(UIElement.XYFocusDownNavigationStrategyProperty, strategy);
        return element;
    }

    public static T XYFocusDown<T>(this T element, DependencyObject xyFocusDown) where T : UIElement
    {
        element.SetValue(UIElement.XYFocusDownProperty, xyFocusDown);
        return element;
    }

    public static T XYFocusKeyboardNavigation<T>(this T element, XYFocusKeyboardNavigationMode keyboardNavigation)
        where T : UIElement
    {
        element.SetValue(UIElement.XYFocusKeyboardNavigationProperty, keyboardNavigation);
        return element;
    }


    public static T XYFocusLeftNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy)
        where T : UIElement
    {
        element.SetValue(UIElement.XYFocusLeftNavigationStrategyProperty, strategy);
        return element;
    }

    public static T XYFocusLeft<T>(this T element, DependencyObject xyFocusLeft) where T : UIElement
    {
        element.SetValue(UIElement.XYFocusLeftProperty, xyFocusLeft);
        return element;
    }

    public static T XYFocusRightNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy)
        where T : UIElement
    {
        element.SetValue(UIElement.XYFocusRightNavigationStrategyProperty, strategy);
        return element;
    }

    public static T XYFocusRight<T>(this T element, DependencyObject xyFocusRight) where T : UIElement
    {
        element.SetValue(UIElement.XYFocusRightProperty, xyFocusRight);
        return element;
    }

    public static T XYFocusUpNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy)
        where T : UIElement
    {
        element.SetValue(UIElement.XYFocusUpNavigationStrategyProperty, strategy);
        return element;
    }

    public static T XYFocusUp<T>(this T element, DependencyObject xyFocusUp) where T : UIElement
    {
        element.SetValue(UIElement.XYFocusUpProperty, xyFocusUp);
        return element;
    }

}