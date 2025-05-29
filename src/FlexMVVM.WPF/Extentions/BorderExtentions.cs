using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF
{
    public static class BorderExtentions
    {
        public static T Background<T>(this T bdr, string colorString) where T : Border
        {
            bdr.Background = BrushTool.Get (colorString);

            return bdr;
        }
        public static T Background<T>(this T bdr, Color color) where T : Border
        {
            bdr.Background = new SolidColorBrush (color);

            return bdr;
        }

        public static T Padding<T>(this T bdr, double marginAll = 0) where T : Border
        {
            bdr.Padding = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return bdr;
        }
        public static T Padding<T>(this T bdr, double leftright = 0, double topbottom = 0) where T : Border
        {
            bdr.Padding = new Thickness (leftright, topbottom, leftright, topbottom);
            return bdr;
        }
        public static T Padding<T>(this T bdr, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Border
        {
            bdr.Padding = new Thickness (left, top, right, bottom);
            return bdr;
        }
        public static T CornerRadius<T>(this T bdr, double marginAll = 0) where T : Border
        {
            bdr.CornerRadius = new CornerRadius (marginAll, marginAll, marginAll, marginAll);
            return bdr;
        }
        public static T CornerRadius<T>(this T bdr, double leftright = 0, double topbottom = 0) where T : Border
        {
            bdr.CornerRadius = new CornerRadius (leftright, topbottom, leftright, topbottom);
            return bdr;
        }
        public static T CornerRadius<T>(this T bdr, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Border
        {
            bdr.CornerRadius = new CornerRadius (left, top, right, bottom);
            return bdr;
        }

        public static T Brush<T>(this T bdr, string colorString) where T : Border
        {
            bdr.BorderBrush = new SolidColorBrush (ColorTool.Get (colorString));

            return bdr;
        }
        public static T Brush<T>(this T bdr, Color color) where T : Border
        {
            bdr.BorderBrush = new SolidColorBrush (color);

            return bdr;
        }
        public static T Thickness<T>(this T bdr, double marginAll = 0) where T : Border
        {
            bdr.BorderThickness = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return bdr;
        }
        public static T Thickness<T>(this T bdr, double leftright = 0, double topbottom = 0) where T : Border
        {
            bdr.BorderThickness = new Thickness (leftright, topbottom, leftright, topbottom);
            return bdr;
        }
        public static T Thickness<T>(this T bdr, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Border
        {
            bdr.BorderThickness = new Thickness (left, top, right, bottom);

            return bdr;
        }
    }
}
