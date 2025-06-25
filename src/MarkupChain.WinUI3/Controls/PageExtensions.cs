namespace MarkupChain.WinUI3.Controls;

public static class PageExtensions
{
    public static T BottomAppbar<T>(this T page, AppBar bottomAppBar) where T : Page
    {
        page.SetValue(Page.BottomAppBarProperty, bottomAppBar);
        return page;
    }
    
    public static T TopAppbar<T>(this T page, AppBar topAppBar) where T : Page
    {
        page.SetValue(Page.TopAppBarProperty, topAppBar);
        return page;
    }

    public static T Frame<T>(this T page, Frame frame) where T : Page
    {
        page.SetValue(Page.FrameProperty, frame);
        return page;
    }
}