namespace MarkupChain.WinUI3.Controls;

public static class AppBarSeparatorExtensions
{
    public static T DynamicOverflowOrder<T>(this T appBarSeparator, int dynamicOverflowOrder) where T : AppBarButton
    {
        appBarSeparator.DynamicOverflowOrder = dynamicOverflowOrder;
        return appBarSeparator;
    }
    
    public static T IsCompact<T>(this T appBarSeparator, bool isCompact) where T : AppBarButton
    {
        appBarSeparator.IsCompact = isCompact;
        return appBarSeparator;
    }

    public static T IsInOverflow<T>(this T appBarSeparator, bool isInOverflow) where T : AppBarButton
    {
        appBarSeparator.SetValue(AppBarButton.IsInOverflowProperty, isInOverflow);
        return appBarSeparator;
    }
}