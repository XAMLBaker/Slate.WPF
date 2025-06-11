using System.Windows;
namespace FlexMVVM.WPF.Markup
{
    public static partial class FrameworkExtensions
    {
        public static T Size<T>(this T fe, double width, double height) where T : FrameworkElement
        {
            fe.Width (width);
            fe.Height (height);
            return fe;
        }
        public static T Margin<T>(this T fe, double marginAll = 0) where T : FrameworkElement
        {
            var temp = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return fe.Margin (temp);
        }
        public static T Margin<T>(this T fe, double leftright = 0, double topbottom = 0) where T : FrameworkElement
        {
            var temp = new Thickness (leftright, topbottom, leftright, topbottom);
            return fe.Margin (temp);
        }
        public static T Margin<T>(this T fe, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : FrameworkElement
        {
            var temp = new Thickness (left, top, right, bottom);
            return fe.Margin (temp);
        }
        public static T Center<T>(this T fe) where T : FrameworkElement
        {
            fe.VCenter ();
            fe.HCenter ();
            return fe;
        }
    }
}
