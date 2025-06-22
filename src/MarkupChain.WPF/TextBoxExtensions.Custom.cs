namespace MarkupChain.WPF
{
    public static partial class TextBoxExtensions
    {

        public static T SelectedText<T>(this T tb, string selectedText) where T : TextBox
        {
            tb.SelectedText = selectedText;
            return tb;
        }

        public static T SelectionStart<T>(this T tb, int selectionStart) where T : TextBox
        {
            tb.SelectionStart = selectionStart;
            return tb;
        }

        public static T SelectionLength<T>(this T tb, int selectionLength) where T : TextBox
        {
            tb.SelectionLength = selectionLength;
            return tb;
        }

        public static T CaretIndex<T>(this T tb, int caretIndex) where T : TextBox
        {
            tb.CaretIndex = caretIndex;
            return tb;
        }

        public static T OnFocus<T>(this T tb, Action action) where T : TextBox
        {
            tb.GotFocus += (_, __) => action ();
            return tb;
        }
        public static T OnLostFocus<T>(this T tb, Action action) where T : TextBox
        {
            tb.LostFocus += (_, __) => action ();
            return tb;
        }
        public static T OnFocus<T>(this T tb, Action<T> action) where T : TextBox
        {
            tb.GotFocus += (_, __) => action (tb);
            return tb;
        }
        public static T OnLostFocus<T>(this T tb, Action<T> action) where T : TextBox
        {
            tb.LostFocus += (_, __) => action (tb);
            return tb;
        }
        public static T OnPreviewText<T>(this T tb, Action action) where T : TextBox
        {
            tb.PreviewTextInput += (_, __) => action ();

            return tb;
        }
    }
}
