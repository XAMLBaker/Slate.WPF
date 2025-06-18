using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Slate.WPF.Markup
{
    public static partial class ControlExtensions
    {
        public static T Background<T>(this T ctrl, string color) where T : Control
           => ctrl.Background (BrushTool.Get (color));

        public static T Background<T>(this T ctrl, Color color) where T : Control
            => ctrl.Background (BrushTool.Get (color));
        public static T Padding<T>(this T ctrl, double marginAll = 0) where T : Control
            => ctrl.Padding (new Thickness (marginAll, marginAll, marginAll, marginAll));

        public static T Padding<T>(this T ctrl, double leftright = 0, double topbottom = 0) where T : Control
            => ctrl.Padding (new Thickness (leftright, topbottom, leftright, topbottom));

        public static T Padding<T>(this T ctrl, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
            => ctrl.Padding (new Thickness (left, top, right, bottom));

        public static T ContentCenter<T>(this T ctrl) where T : Control
        {
            ctrl.ContentHCenter ();
            ctrl.ContentVCenter ();
            return ctrl;
        }
        public static T ContentVCenter<T>(this T ctrl) where T : Control
            => ctrl.VerticalContentAlignment (VerticalAlignment.Center);

        public static T ContentTop<T>(this T ctrl) where T : Control
            => ctrl.VerticalContentAlignment (VerticalAlignment.Top);

        public static T ContentBottom<T>(this T ctrl) where T : Control
            => ctrl.VerticalContentAlignment (VerticalAlignment.Bottom);

        public static T ContentHCenter<T>(this T ctrl) where T : Control
            => ctrl.HorizontalContentAlignment (HorizontalAlignment.Center);
        public static T ContentLeft<T>(this T ctrl) where T : Control
            => ctrl.HorizontalContentAlignment (HorizontalAlignment.Left);
        public static T ContentRight<T>(this T ctrl) where T : Control
            => ctrl.HorizontalContentAlignment (HorizontalAlignment.Right);

        public static T BorderBrush<T>(this T ctrl, string color) where T : Control
            => ctrl.BorderBrush (BrushTool.Get (color));

        public static T BorderBrush<T>(this T ctrl, Color color) where T : Control
            => ctrl.BorderBrush (BrushTool.Get (color));

        public static T BorderThickness<T>(this T ctrl, double marginAll = 0) where T : Control
            => ctrl.BorderThickness (new Thickness (marginAll, marginAll, marginAll, marginAll));

        public static T BorderThickness<T>(this T ctrl, double leftright = 0, double topbottom = 0) where T : Control
            => ctrl.BorderThickness (new Thickness (leftright, topbottom, leftright, topbottom));

        public static T BorderThickness<T>(this T ctrl, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
            => ctrl.BorderThickness (new Thickness (left, top, right, bottom));

        public static T Foreground<T>(this T ctrl, string color) where T : Control
            => ctrl.Foreground (BrushTool.Get (color));

        public static T Foreground<T>(this T ctrl, Color color) where T : Control
            => ctrl.Foreground (BrushTool.Get (color));
    }
}
