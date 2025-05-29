using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF.Markup
{
    public static class TextBlockExtentions
    {
        public static T Text<T>(this T tb, string text) where T : TextBlock
        {
            tb.Text = text;
            return tb;
        }

        public static T Foreground<T>(this T tb, Brush color) where T : TextBlock
        {
            tb.SetValue (TextBlock.ForegroundProperty, color);

            return tb;
        }

        public static T Foreground<T>(this T tb, string color) where T : TextBlock
             => tb.Foreground (BrushTool.Get (color));

        public static T Foreground<T>(this T tb, Color color) where T : TextBlock
            => tb.Foreground (BrushTool.Get (color));

        public static T Background<T>(this T tb, Brush color) where T : TextBlock
        {
            tb.SetValue (TextBlock.BackgroundProperty, color);
            return tb;
        }
        public static T Background<T>(this T tb, string color) where T : TextBlock
            => tb.Background (BrushTool.Get (color));
        public static T Background<T>(this T tb, Color color) where T : TextBlock
            => tb.Background (BrushTool.Get (color));

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
        public static T Padding<T>(this T element, Thickness thickness) where T : TextBlock
        {
            if (thickness == null)
                return element;
            element.SetValue (TextBlock.PaddingProperty, thickness);
            return element;
        }
    }
}
