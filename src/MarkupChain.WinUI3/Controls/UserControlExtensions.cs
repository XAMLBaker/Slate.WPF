namespace MarkupChain.WinUI3.Controls;

public static class UserControlExtensions
{
    public static T Content<T>(this T userControl, UIElement content) where T : UserControl
    {
        userControl.SetValue(UserControl.ContentProperty, content);
        return userControl;
    }
}