using System.Windows.Shapes;

namespace MarkupChain.WPF
{
    public static partial class ShapeExtensions
    {
        public static T Fill<T>(this T shape, string color) where T : Shape
            => shape.Fill(BrushTool.Get (color));

        public static T Fill<T>(this T shape, Color color) where T : Shape
            => shape.Fill (BrushTool.Get (color));

        public static T Stroke<T>(this T shape, string color) where T : Shape
             => shape.Stroke (BrushTool.Get (color));

        public static T Stroke<T>(this T shape, Color color) where T : Shape
            => shape.Stroke (BrushTool.Get (color));

        public static T StrokeLineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeStartLineCap(lineCap);
            shape.StrokeLineCap(lineCap);

            return shape;
        }
    }
}
