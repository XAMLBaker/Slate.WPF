namespace MarkupChain.WPF
{
    public static class TextBoxExtensions
    {
        public static T OnFocus<T>(this T element, Action action) where T : TextBox
        {
            element.GotFocus += (_, __) => action ();
            return element;
        }
        public static T OnLostFocus<T>(this T element, Action action) where T : TextBox
        {
            element.LostFocus += (_, __) => action ();
            return element;
        }
        public static T OnFocus<T>(this T element, Action<T> action) where T : TextBox
        {
            element.GotFocus += (_, __) => action (element);
            return element;
        }
        public static T OnLostFocus<T>(this T element, Action<T> action) where T : TextBox
        {
            element.LostFocus += (_, __) => action (element);
            return element;
        }
        public static T OnPreviewText<T>(this T tb, Action action) where T : TextBox
        {
            tb.PreviewTextInput += (_, __) => action ();

            return tb;
        }
        public static T OnTextChanged<T>(this T tb, Action action) where T : TextBox
        {
            tb.TextChanged += (_, __) => action ();

            return tb;
        }

        public static T OnTextChanged<T>(this T tb, TextChangedEventHandler action) where T : TextBox
        {
            tb.TextChanged += (_, __) => action (_, __);

            return tb;
        }
        public static T SelectionBrush<T>(this T tb, string color) where T : TextBox
        {
            tb.SelectionBrush (BrushTool.Get (color));
            return tb;
        }

        public static T SelectionBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.SelectionBrush (BrushTool.Get (color));
            return tb;
        }

        public static T SelectionBrush<T>(this T tb, Brush brush) where T : TextBox
        {
            tb.SelectionBrush = brush;
            return tb;
        }

        public static T SelectionTextBrush<T>(this T tb, string color) where T : TextBox
        {
            tb.SelectionTextBrush(BrushTool.Get (color));

            return tb;
        }
        public static T SelectionTextBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.SelectionTextBrush (BrushTool.Get (color));
            return tb;
        }

        public static T SelectionTextBrush<T>(this T tb, Brush brush) where T : TextBox
        {
            tb.SelectionTextBrush = brush;
            return tb;
        }

        public static T CaretBrush<T>(this T tb, string color) where T : TextBox
        {
            tb.CaretBrush (BrushTool.Get (color));

            return tb;
        }

        public static T CaretBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.CaretBrush (BrushTool.Get (color));
            return tb;
        }

        public static T CaretBrush<T>(this T tb, Brush brush) where T : TextBox
        {
            tb.CaretBrush = brush;
            return tb;
        }
    }
}
