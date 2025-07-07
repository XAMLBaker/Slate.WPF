namespace MarkupChain.WinUI3.Controls;

public static class AppBarExtensions
{
    public static T ClosedDisplayMode<T>(this T appBar, AppBarClosedDisplayMode mode) where T : AppBar
    {
        appBar.SetValue(AppBar.ClosedDisplayModeProperty, mode);
        return appBar;
    }

    public static T IsOpen<T>(this T appBar, bool isOpen) where T : AppBar
    {
        appBar.SetValue(AppBar.IsOpenProperty, isOpen);
        return appBar;
    }

    public static T IsSticky<T>(this T appBar, bool isSticky) where T : AppBar
    {
        appBar.SetValue(AppBar.IsStickyProperty, isSticky);
        return appBar;
    }

    public static T LightDismissOverlayMode<T>(this T appBar, LightDismissOverlayMode mode) where T : AppBar
    {
        appBar.SetValue(AppBar.LightDismissOverlayModeProperty, mode);
        return appBar;
    }
}