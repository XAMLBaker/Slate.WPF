namespace MarkupChain.WPF
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
            return fe.VCenter () 
                     .HCenter ();
        }
        public static T Stretch<T>(this T fe) where T : FrameworkElement
        {
            return fe.VStretch ()
                     .HStretch ();
        }
        public static T VStretch<T>(this T fe) where T : FrameworkElement
        {
            return fe.VerticalAlignment (System.Windows.VerticalAlignment.Stretch);
        }
        public static T VCenter<T>(this T fe) where T : FrameworkElement
        {
            return fe.VerticalAlignment (System.Windows.VerticalAlignment.Center);
        }
        public static T Top<T>(this T fe) where T : FrameworkElement
        {
            return fe.VerticalAlignment (System.Windows.VerticalAlignment.Top);
        }
        public static T Bottom<T>(this T fe) where T : FrameworkElement
        {
            return fe.VerticalAlignment (System.Windows.VerticalAlignment.Bottom);
        }
        public static T HStretch<T>(this T fe) where T : FrameworkElement
        {
            return fe.HorizontalAlignment (System.Windows.HorizontalAlignment.Stretch);
        }
        public static T HCenter<T>(this T fe) where T : FrameworkElement
        {
            return fe.HorizontalAlignment (System.Windows.HorizontalAlignment.Center);
        }
        public static T Left<T>(this T fe) where T : FrameworkElement
        {
            return fe.HorizontalAlignment (System.Windows.HorizontalAlignment.Left);
        }
        public static T Right<T>(this T fe) where T : FrameworkElement
        {
            return fe.HorizontalAlignment (System.Windows.HorizontalAlignment.Right);
        }
    }
}
