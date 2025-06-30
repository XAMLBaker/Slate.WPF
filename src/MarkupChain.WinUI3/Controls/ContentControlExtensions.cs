namespace MarkupChain.WinUI3.Controls;

public static class ContentControlExtensions
{
    public static T Content<T>(this T userControl, UIElement content) where T : ContentControl
    {
        userControl.SetValue(ContentControl.ContentProperty, content);
        return userControl;
    }
}