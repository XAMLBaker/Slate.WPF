namespace MarkupChain.WPF
{
    public static partial class TextBlockExtensions
    {
        public static T Foreground<T>(this T tb, string color) where T : TextBlock
             => tb.Foreground (BrushTool.Get (color));

        public static T Foreground<T>(this T tb, Color color) where T : TextBlock
            => tb.Foreground (BrushTool.Get (color));

        public static T Background<T>(this T tb, string color) where T : TextBlock
            => tb.Background (BrushTool.Get (color));
        public static T Background<T>(this T tb, Color color) where T : TextBlock
            => tb.Background (BrushTool.Get (color));

        public static T Padding<T>(this T element, double marginAll = 0) where T : TextBlock
        {
            return element.Padding (new Thickness (marginAll, marginAll, marginAll, marginAll));
        }
        public static T Padding<T>(this T element, double leftright = 0, double topbottom = 0) where T : TextBlock
        {
            return element.Padding (new Thickness (leftright, topbottom, leftright, topbottom));
        }
        public static T Padding<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : TextBlock
        {
            return element.Padding (new Thickness (left, top, right, bottom));
        }
    }
}
