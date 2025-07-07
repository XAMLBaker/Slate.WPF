namespace MarkupChain.WinUI3.Controls;

public static class AppBarSeparatorExtensions
{
    public static T DynamicOverflowOrder<T>(this T appBarButton, int dynamicOverflowOrder) where T : AppBarButton
    {
        appBarButton.DynamicOverflowOrder = dynamicOverflowOrder;
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
}