using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public static class ContentControlExtentions
    {
        public static T Content<T>(this T cc, object obj) where T : ContentControl
        {
            cc.SetValue (ContentControl.ContentProperty, obj);
            return cc;
        }
        
        public static T ContentCenter<T>(this T cc) where T : ContentControl
        {
            cc.ContentHCenter ();
            cc.ContentVCenter ();
            return cc;
        }
        public static T ContentVCenter<T>(this T cc) where T : ContentControl
        {
            cc.SetValue (ContentControl.VerticalContentAlignmentProperty, VerticalAlignment.Center);
            return cc;
        }
        public static T ContentTop<T>(this T cc) where T : ContentControl
        {
            cc.SetValue (ContentControl.VerticalContentAlignmentProperty, VerticalAlignment.Top);
            return cc;
        }
        public static T ContentBottom<T>(this T cc) where T : ContentControl
        {
            cc.SetValue (ContentControl.VerticalContentAlignmentProperty, VerticalAlignment.Bottom);
            return cc;
        }
        public static T ContentHCenter<T>(this T cc) where T : ContentControl
        {
            cc.SetValue (ContentControl.HorizontalContentAlignmentProperty, HorizontalAlignment.Center);
            return cc;
        }
        public static T ContentLeft<T>(this T cc) where T : ContentControl
        {
            cc.SetValue (ContentControl.HorizontalContentAlignmentProperty, HorizontalAlignment.Left);
            return cc;
        }
        public static T ContentRight<T>(this T cc) where T : ContentControl
        {
            cc.SetValue (ContentControl.HorizontalContentAlignmentProperty, HorizontalAlignment.Right);
            return cc;
        }
    }
}
