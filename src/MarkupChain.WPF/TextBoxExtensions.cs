using System.Windows.Controls.Primitives;

namespace MarkupChain.WPF
{
    public static partial class TextBoxExtensions
    {
        public static T CharacterCasing<T>(this T tb, CharacterCasing characterCasing) where T : TextBox
        {
            tb.SetValue (TextBox.CharacterCasingProperty, characterCasing);
            return tb;
        }

        public static T MaxLength<T>(this T tb, int maxLength) where T : TextBox
        {
            tb.SetValue(TextBox.MaxLengthProperty, maxLength);

            return tb;
        }

        public static T MaxLines<T>(this T tb, int maxLines) where T : TextBox
        {
            tb.SetValue (TextBox.MaxLinesProperty, maxLines);

            return tb;
        }

        public static T MinLines<T>(this T tb, int minLines) where T : TextBox
        {
            tb.SetValue (TextBox.MinLinesProperty, minLines);

            return tb;
        }

        public static T TextAlignment<T>(this T tb, TextAlignment textAlignment) where T : TextBox
        {
            tb.SetValue (TextBox.TextAlignmentProperty, textAlignment);

            return tb;
        }

        public static T TextDecorations<T>(this T tb, TextDecorationCollection textDecorations) where T : TextBox
        {
            tb.SetValue (TextBox.TextDecorationsProperty, textDecorations);

            return tb;
        }
        public static T Text<T>(this T tb, string text) where T : TextBox
        {
            tb.SetValue (TextBox.TextProperty, text);

            return tb;
        }

        public static T TextWrapping<T>(this T tb, TextWrapping textWrapping) where T : TextBox
        {
            tb.SetValue (TextBox.TextWrappingProperty, textWrapping);

            return tb;
        }
    }
}
