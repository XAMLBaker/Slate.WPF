namespace MarkupChain.WinUI3
{
    //an extension class which able to chaining -Property(=DependencyProperty) affix Properties.
    public static class BrushExtensions
    {
        public static T Opacity<T>(this T brush, double opacity) where T : Brush
        {
            brush.SetValue(Brush.OpacityProperty, opacity);
            return brush;
        }
        
        public static T RelativeTransform<T>(this T brush, Transform relativeTransform) where T : Brush
        {
            brush.SetValue(Brush.RelativeTransformProperty, relativeTransform);
            return brush;
        }
        
        public static T Transform<T>(this T brush, Transform transform) where T : Brush
        {
            brush.SetValue(Brush.TransformProperty, transform);
            return brush;
        }
    }
}