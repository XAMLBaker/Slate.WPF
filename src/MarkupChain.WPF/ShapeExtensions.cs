using System.Windows.Shapes;

namespace MarkupChain.WPF
{
    public static class ShapeExtensions
    {
        public static T Fill<T>(this T shape, Brush color) where T : Shape
        {
            shape.SetValue (Shape.FillProperty, color);
            return shape;
        }
        public static T Fill<T>(this T shape, string color) where T : Shape
            => shape.Fill(BrushTool.Get (color));

        public static T Fill<T>(this T shape, Color color) where T : Shape
            => shape.Fill (BrushTool.Get (color));

        public static T Stroke<T>(this T shape, Brush color) where T : Shape
        {
            shape.SetValue (Shape.StrokeProperty, color);
            return shape;
        }

        public static T Stroke<T>(this T shape, string color) where T : Shape
             => shape.Stroke (BrushTool.Get (color));

        public static T Stroke<T>(this T shape, Color color) where T : Shape
            => shape.Stroke (BrushTool.Get (color));

        public static T StrokeDashArray<T>(this T shape, DoubleCollection strokeDashArray) where T : Shape
        {
            shape.SetValue (Shape.StrokeDashArrayProperty, strokeDashArray);
            return shape;
        }

        public static T StrokeMiterLimit<T>(this T shape, double strokeMiterLimit) where T : Shape
        {
            shape.SetValue (Shape.StrokeMiterLimitProperty, strokeMiterLimit);
            return shape;
        }

        public static T StrokeLineJoin<T>(this T shape, PenLineJoin penLineJoin) where T : Shape
        {
            shape.SetValue (Shape.StrokeLineJoinProperty, penLineJoin);
            return shape;
        }

        public static T StrokeEndLineCap<T>(this T shape, PenLineJoin penLineJoin) where T : Shape
        {
            shape.SetValue (Shape.StrokeEndLineCapProperty, penLineJoin);
            return shape;
        }
        public static T StrokeDashOffset<T>(this T shape, double strokeDashOffset) where T : Shape
        {
            shape.SetValue (Shape.StrokeDashOffsetProperty, strokeDashOffset);
            return shape;
        }

        public static T StrokeDashCap<T>(this T shape, PenLineJoin strokeDashCap) where T : Shape
        {
            shape.SetValue (Shape.StrokeDashCapProperty, strokeDashCap);
            return shape;
        }

        public static T StrokeThickness<T>(this T shape, double strokeThickness) where T : Shape
        {
            shape.SetValue (Shape.StrokeThicknessProperty, strokeThickness);
            return shape;
        }
        public static T StrokeStartLineCap<T>(this T shape, PenLineCap penLineJoin) where T : Shape
        {
            shape.SetValue (Shape.StrokeStartLineCapProperty, penLineJoin);
            return shape;
        }

        public static T Stretch<T>(this T shape, Stretch stretch) where T : Shape
        {
            shape.SetValue (Shape.StretchProperty, stretch);
            return shape;
        }

        public static T StrokeLineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeStartLineCap(lineCap);
            shape.StrokeLineCap(lineCap);

            return shape;
        }
    }
}
