using System.Windows.Controls.Primitives;

namespace MarkupChain.WPF
{
    public static partial class TextBoxBaseExtensions
    {
        public static T OnSelectionChanged<T>(this T tb, Action action) where T : TextBoxBase
        {
            tb.SelectionChanged += (_, __) => action ();

            return tb;
        }

        public static T OnSelectionChanged<T>(this T tb, RoutedEventHandler action) where T : TextBoxBase
        {
            tb.SelectionChanged += (_, __) => action (_, __);

            return tb;
        }

        public static T OnTextChanged<T>(this T tb, Action action) where T : TextBoxBase
        {
            tb.TextChanged += (_, __) => action ();

            return tb;
        }

        public static T OnTextChanged<T>(this T tb, TextChangedEventHandler action) where T : TextBoxBase
        {
            tb.TextChanged += (_, __) => action (_, __);

            return tb;
        }
        public static T SelectionBrush<T>(this T tb, string color) where T : TextBoxBase
        {
            return tb.SelectionBrush (BrushTool.Get (color));
        }

        public static T SelectionBrush<T>(this T tb, Color color) where T : TextBoxBase
        {
            return tb.SelectionBrush (BrushTool.Get (color));
        }

        public static T SelectionTextBrush<T>(this T tb, string color) where T : TextBoxBase
        {
            return tb.SelectionTextBrush(BrushTool.Get (color));
        }
        public static T SelectionTextBrush<T>(this T tb, Color color) where T : TextBoxBase
        {
            return tb.SelectionTextBrush (BrushTool.Get (color));
        }

        public static T CaretBrush<T>(this T tb, string color) where T : TextBoxBase
        {
            return tb.CaretBrush (BrushTool.Get (color));
        }

        public static T CaretBrush<T>(this T tb, Color color) where T : TextBoxBase
        {
            return tb.CaretBrush (BrushTool.Get (color));
        }
    }
}
