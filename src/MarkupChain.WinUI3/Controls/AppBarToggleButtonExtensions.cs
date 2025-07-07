namespace MarkupChain.WinUI3.Controls;

public static class AppBarToggleButtonExtensions
{
    public static T DynamicOverflowOrder<T>(this T appBarToggleButton, int dynamicOverflowOrder) where T : AppBarToggleButton
    {
        appBarToggleButton.DynamicOverflowOrder = dynamicOverflowOrder;
        return appBarToggleButton;
    }

    public static T Icon<T>(this T appBarToggleButton, IconElement icon) where T : AppBarToggleButton
    {
        appBarToggleButton.SetValue(AppBarToggleButton.IconProperty, icon);
        return appBarToggleButton;
    }

    public static T IsCompact<T>(this T appBarToggleButton, bool isCompact) where T : AppBarToggleButton
    {
        appBarToggleButton.IsCompact = isCompact;
        return appBarToggleButton;
    }

    public static T IsInOverflow<T>(this T appBarToggleButton, bool isInOverflow) where T : AppBarToggleButton
    {
        appBarToggleButton.SetValue(AppBarToggleButton.IsInOverflowProperty, isInOverflow);
        return appBarToggleButton;
    }
    
    public static T KeyboardAcceleratorTextOverride<T>(this T appBarToggleButton, string keyboardAcceleratorTextOverride)
        where T : AppBarToggleButton
    {
        appBarToggleButton.SetValue(AppBarToggleButton.KeyboardAcceleratorTextOverrideProperty, keyboardAcceleratorTextOverride);
        return appBarToggleButton;
    }
    
    public static T Label<T>(this T appBarToggleButton, string label) where T : AppBarToggleButton
    {
        appBarToggleButton.SetValue(AppBarToggleButton.LabelProperty, label);
        return appBarToggleButton;
    }
    
    public static T LabelPosition<T>(this T appBarToggleButton, CommandBarLabelPosition labelPosition) where T : AppBarToggleButton
    {
        appBarToggleButton.SetValue(AppBarToggleButton.LabelPositionProperty, labelPosition);
        return appBarToggleButton;
    }
}