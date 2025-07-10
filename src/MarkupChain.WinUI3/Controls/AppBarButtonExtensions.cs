namespace MarkupChain.WinUI3.Controls;

public static class AppBarButtonExtensions
{
    public static T DynamicOverflowOrder<T>(this T appBarButton, int dynamicOverflowOrder) where T : AppBarButton
    {
        appBarButton.DynamicOverflowOrder = dynamicOverflowOrder;
        return appBarButton;
    }

    public static T Icon<T>(this T appBarButton, IconElement icon) where T : AppBarButton
    {
        appBarButton.SetValue(AppBarButton.IconProperty, icon);
        return appBarButton;
    }

    public static T IsCompact<T>(this T appBarButton, bool isCompact) where T : AppBarButton
    {
        appBarButton.IsCompact = isCompact;
        return appBarButton;
    }

    public static T IsInOverflow<T>(this T appBarButton, bool isInOverflow) where T : AppBarButton
    {
        appBarButton.SetValue(AppBarButton.IsInOverflowProperty, isInOverflow);
        return appBarButton;
    }

    public static T KeyboardAcceleratorTextOverride<T>(this T appBarButton, string keyboardAcceleratorTextOverride)
        where T : AppBarButton
    {
        appBarButton.SetValue(AppBarButton.KeyboardAcceleratorTextOverrideProperty, keyboardAcceleratorTextOverride);
        return appBarButton;
    }

    public static T Label<T>(this T appBarButton, string label) where T : AppBarButton
    {
        appBarButton.SetValue(AppBarButton.LabelProperty, label);
        return appBarButton;
    }
    
    public static T LabelPosition<T>(this T appBarButton, CommandBarLabelPosition labelPosition) where T : AppBarButton
    {
        appBarButton.SetValue(AppBarButton.LabelPositionProperty, labelPosition);
        return appBarButton;
    }
}