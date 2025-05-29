using System.Windows.Controls;

namespace FlexMVVM.WPF.Markup
{
    public static class ContentControlExtentions
    {
        public static T Content<T>(this T cc, object obj) where T : ContentControl
        {
            cc.SetValue (ContentControl.ContentProperty, obj);
            return cc;
        }
    }
}
