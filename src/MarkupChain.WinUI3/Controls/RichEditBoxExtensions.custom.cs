using Windows.UI;

namespace MarkupChain.WinUI3.Controls
{
    public static partial class RichEditBoxExtensions
    {
        public static T SelectionHighlightColor<T>(this T richEditBox, string selectionHighlightColor) where T : RichEditBox
        {
            return richEditBox.SelectionHighlightColor (ColorTool.Get (selectionHighlightColor));
        }
        public static T SelectionHighlightColor<T>(this T richEditBox, Color selectionHighlightColor) where T : RichEditBox
        {
            return richEditBox.SelectionHighlightColor (new SolidColorBrush (selectionHighlightColor));
        }
        public static T SelectionHighlightColorWhenNotFocused<T>(this T richEditBox, string selectionHighlightColorWhenNotFocused) where T : RichEditBox
        {
            return richEditBox.SelectionHighlightColor (ColorTool.Get (selectionHighlightColorWhenNotFocused));
        }
        public static T SelectionHighlightColorWhenNotFocused<T>(this T richEditBox, Color selectionHighlightColorWhenNotFocused) where T : RichEditBox
        {
            return richEditBox.SelectionHighlightColor (new SolidColorBrush (selectionHighlightColorWhenNotFocused));
        }
    }
}
