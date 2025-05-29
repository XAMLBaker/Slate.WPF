using System.Windows.Media;
using System.Windows.Shapes;

namespace FlexMVVM.WPF
{
    public static class ShapeExtentions
    {
        public static T Fill<T>(this T shape, string colorString) where T : Shape
        {
            shape.Fill = BrushTool.Get (colorString);

            return shape;
        }

        public static T Fill<T>(this T shape, Color color) where T : Shape
        {
            shape.Fill = new SolidColorBrush (color);

            return shape;

        }
        public static T Brush<T>(this T shape, string colorString) where T : Shape
        {
            shape.Stroke = BrushTool.Get (colorString);

            return shape;
        }

        public static T Brush<T>(this T shape, Color color) where T : Shape
        {
            shape.Stroke = new SolidColorBrush (color);

            return shape;
        }

        public static T DashArray<T>(this T shape, DoubleCollection strokeDashArray) where T : Shape
        {
            shape.StrokeDashArray = strokeDashArray;

            return shape;
        }
        public static T MiterLimit<T>(this T shape, double strokeMiterLimit) where T : Shape
        {
            shape.StrokeMiterLimit = strokeMiterLimit;

            return shape;
        }

        public static T LineJoin<T>(this T shape, PenLineJoin penLineJoin) where T : Shape
        {
            shape.StrokeLineJoin = penLineJoin;

            return shape;
        }
        public static T DashCap<T>(this T shape, PenLineCap strokeDashCap) where T : Shape
        {
            shape.StrokeDashCap = strokeDashCap;

            return shape;
        }
        public static T LineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeStartLineCap = lineCap;
            shape.StrokeEndLineCap = lineCap;

            return shape;
        }

        public static T StartLineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeStartLineCap = lineCap;

            return shape;
        }

        public static T EndLineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeEndLineCap = lineCap;

            return shape;
        }

        public static T Thickness<T>(this T shape, double marginAll = 0) where T : Shape
        {
            shape.StrokeThickness = marginAll;

            return shape;
        }
    }
}
