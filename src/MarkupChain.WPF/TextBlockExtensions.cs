namespace MarkupChain.WPF
{
    public static partial class TextBlockExtensions
    {
        public static T Text<T>(this T tb, string text) where T : TextBlock
        {
            tb.SetValue(TextBlock.TextProperty, text);
            return tb;
        }

        public static T Foreground<T>(this T tb, Brush color) where T : TextBlock
        {
            tb.SetValue (TextBlock.ForegroundProperty, color);

            return tb;
        }

        public static T Background<T>(this T tb, Brush color) where T : TextBlock
        {
            tb.SetValue (TextBlock.BackgroundProperty, color);
            return tb;
        }

        public static T FontSize<T>(this T element, double size) where T : TextBlock
        {
            element.SetValue (TextBlock.FontSizeProperty, size);

            return element;
        }

        public static T FontFamliy<T>(this T element, FontFamily fontFamliy) where T : TextBlock
        {
            element.SetValue (TextBlock.FontFamilyProperty, fontFamliy);
            return element;
        }

        public static T FontWeight<T>(this T element, FontWeight size) where T : TextBlock
        {
            element.SetValue (TextBlock.FontWeightProperty, size);
            return element;
        }
        public static T FontStyle<T>(this T element, FontStyle style) where T : TextBlock
        {
            element.SetValue (TextBlock.FontStyleProperty, style);

            return element;
        }
        public static T FontStretch<T>(this T element, FontStretch stretch) where T : TextBlock
        {
            element.SetValue (TextBlock.FontStretchProperty, stretch);

            return element;
        }
        public static T Padding<T>(this T element, Thickness thickness) where T : TextBlock
        {
            if (thickness == null)
                return element;
            element.SetValue (TextBlock.PaddingProperty, thickness);
            return element;
        }
    }
}
