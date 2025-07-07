namespace MarkupChain.WinUI3.Controls.Primitives;

public static class FlyoutBaseExtensions
{
    public static T AllowFocusOnInteraction<T>(this T flyoutBase, bool allowFocusOnInteraction) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.AllowFocusOnInteractionProperty, allowFocusOnInteraction);
        return flyoutBase;
    }
    
    public static T AllowFocusWhenDisabled<T>(this T flyoutBase, bool allowFocusWhenDisabled) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.AllowFocusWhenDisabledProperty, allowFocusWhenDisabled);
        return flyoutBase;
    }
    
    public static T AreOpenCloseAnimationsEnabled<T>(this T flyoutBase, bool areOpenCloseAnimationsEnabled) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.AreOpenCloseAnimationsEnabledProperty, areOpenCloseAnimationsEnabled);
        return flyoutBase;
    }
    
    public static T ElementSoundMode<T> (this T flyoutBase, ElementSoundMode elementSoundMode) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.ElementSoundModeProperty, elementSoundMode);
        return flyoutBase;
    }
    
    public static T InputDevicePrefersPrimaryCommands<T>(this T flyoutBase, bool inputDevicePrefersPrimaryCommands) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.InputDevicePrefersPrimaryCommandsProperty, inputDevicePrefersPrimaryCommands);
        return flyoutBase;
    }
    
    public static T IsOpen<T>(this T flyoutBase, bool isOpen) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.IsOpenProperty, isOpen);
        return flyoutBase;
    }
    
    public static T LightDismissOverlayMode<T>(this T flyoutBase, LightDismissOverlayMode lightDismissOverlayMode) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.LightDismissOverlayModeProperty, lightDismissOverlayMode);
        return flyoutBase;
    }
    
    public static T OverlayInputPassThroughElement<T>(this T flyoutBase, DependencyObject overlayInputPassThroughElement) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.OverlayInputPassThroughElementProperty, overlayInputPassThroughElement);
        return flyoutBase;
    }
    
    public static T Placement<T>(this T flyoutBase, FlyoutPlacementMode placement) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.PlacementProperty, placement);
        return flyoutBase;
    }
    
    public static T ShouldConstrainToRootBounds<T>(this T flyoutBase, bool shouldConstrainToRootBounds) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.ShouldConstrainToRootBoundsProperty, shouldConstrainToRootBounds);
        return flyoutBase;
    }
    
    public static T ShowMode<T>(this T flyoutBase, FlyoutShowMode showMode) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.ShowModeProperty, showMode);
        return flyoutBase;
    }
    
    public static T Target<T>(this T flyoutBase, FrameworkElement target) where T : FlyoutBase
    {
        flyoutBase.SetValue(FlyoutBase.TargetProperty, target);
        return flyoutBase;
    }
}