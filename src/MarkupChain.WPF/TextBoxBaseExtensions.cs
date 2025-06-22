using System.Windows.Controls.Primitives;

namespace MarkupChain.WPF
{
    public static partial class TextBoxBaseExtensions
    {
        public static T AcceptsReturn<T>(this T tb, bool acceptsReturn) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.AcceptsReturnProperty, acceptsReturn);
            return tb;
        }
        public static T VerticalScrollBarVisibility<T>(this T tb, ScrollBarVisibility verticalScrollBarVisibility) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
            return tb;
        }

        public static T UndoLimit<T>(this T tb, ScrollBarVisibility undoLimit) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.UndoLimitProperty, undoLimit);
            return tb;
        }

        public static T SelectionOpacity<T>(this T tb, double selectionOpacity) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.SelectionOpacityProperty, selectionOpacity);
            return tb;
        }

        public static T SelectionBrush<T>(this T tb, Brush brush) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.SelectionBrushProperty, brush);
            return tb;
        }
        public static T IsUndoEnabled<T>(this T tb, bool isUndoEnabled) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.IsUndoEnabledProperty, isUndoEnabled);
            return tb;
        }

        public static T SelectionTextBrush<T>(this T tb, Brush brush) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.SelectionTextBrushProperty, brush);
            return tb;
        }

        public static T IsReadOnly<T>(this T tb, bool isReadOnlyProperty) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.IsReadOnlyProperty, isReadOnlyProperty);
            return tb;
        }
        public static T IsReadOnlyCaretVisible<T>(this T tb, bool isReadOnlyCaretVisible) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.IsReadOnlyCaretVisibleProperty, isReadOnlyCaretVisible);
            return tb;
        }

        public static T IsInactiveSelectionHighlightEnabled<T>(this T tb, bool isInactiveSelectionHighlightEnabled) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.IsInactiveSelectionHighlightEnabledProperty, isInactiveSelectionHighlightEnabled);
            return tb;
        }
        public static T HorizontalScrollBarVisibility<T>(this T tb, ScrollBarVisibility horizontalScrollBarVisibility) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
            return tb;
        }

        public static T CaretBrush<T>(this T tb, Brush brush) where T : TextBoxBase
        {
            tb.SetValue(TextBoxBase.CaretBrushProperty, brush);
            return tb;
        }

        public static T AutoWordSelection<T>(this T tb, bool autoWordSelection) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.AutoWordSelectionProperty, autoWordSelection);
            return tb;
        }
        public static T AcceptsTab<T>(this T tb, bool acceptsTab) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.AcceptsTabProperty, acceptsTab);
            return tb;
        }
        public static T IsSelectionActive<T>(this T tb, bool isSelectionActive) where T : TextBoxBase
        {
            tb.SetValue (TextBoxBase.IsSelectionActiveProperty, isSelectionActive);
            return tb;
        }
    }
}
