using Windows.Foundation;

namespace MarkupChain.WinUI3.Controls
{
    public static partial class TextBoxExtensions
    {
        public static T BorderBrush<T>(this T textBox, Brush color) where T : TextBox
        {
            textBox.SetValue (TextBox.BorderBrushProperty, color);
            return textBox;
        }

        public static T BorderThickness<T>(this T textBox, Thickness thickness) where T : TextBox
        {
            textBox.SetValue (TextBox.BorderThicknessProperty, thickness);
            return textBox;
        }
        public static T AcceptsReturn<T>(this T textBox, bool acceptsReturn) where T : TextBox
        {
            textBox.SetValue (TextBox.AcceptsReturnProperty, acceptsReturn);
            return textBox;
        }
        public static T CanPasteClipboardContent<T>(this T textBox) where T : TextBox
        {
            textBox.SetValue (TextBox.CanPasteClipboardContentProperty, true);
            return textBox;
        }
        public static T CanRedo<T>(this T textBox) where T : TextBox
        {
            textBox.SetValue (TextBox.CanRedoProperty, true);
            return textBox;
        }
        public static T CanUndo<T>(this T textBox) where T : TextBox
        {
            textBox.SetValue (TextBox.CanUndoProperty, true);
            return textBox;
        }
        public static T CharacterCasing<T>(this T textBox, CharacterCasing characterCasing) where T : TextBox
        {
            textBox.SetValue (TextBox.CharacterCasingProperty, characterCasing);
            return textBox;
        }
        public static T Description<T>(this T textBox, object description) where T : TextBox
        {
            textBox.SetValue (TextBox.DescriptionProperty, description);
            return textBox;
        }
        public static T DesiredCandidateWindowAlignment<T>(this T textBox, CandidateWindowAlignment desiredCandidateWindowAlignment) where T : TextBox
        {
            textBox.SetValue (TextBox.DesiredCandidateWindowAlignmentProperty, desiredCandidateWindowAlignment);
            return textBox;
        }
        public static T Header<T>(this T textBox, object header) where T : TextBox
        {
            textBox.SetValue (TextBox.HeaderProperty, header);
            return textBox;
        }
        public static T HeaderTemplate<T>(this T textBox, DataTemplate headerTemplate) where T : TextBox
        {
            textBox.SetValue (TextBox.HeaderTemplateProperty, headerTemplate);
            return textBox;
        }
        public static T HorizontalTextAlignment<T>(this T textBox, TextAlignment horizontalTextAlignment) where T : TextBox
        {
            textBox.SetValue (TextBox.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return textBox;
        }
        public static T InputScope<T>(this T textBox, InputScope inputScope) where T : TextBox
        {
            textBox.SetValue (TextBox.InputScopeProperty, inputScope);
            return textBox;
        }
        public static T IsColorFontEnabled<T>(this T textBox, bool isColorFontEnabled) where T : TextBox
        {
            textBox.SetValue (TextBox.IsColorFontEnabledProperty, isColorFontEnabled);
            return textBox;
        }
        public static T IsReadOnly<T>(this T textBox, bool isReadOnly) where T : TextBox
        {
            textBox.SetValue (TextBox.IsReadOnlyProperty, isReadOnly);
            return textBox;
        }
        public static T IsSpellCheckEnabled<T>(this T textBox, bool isSpellCheckEnabled) where T : TextBox
        {
            textBox.SetValue (TextBox.IsSpellCheckEnabledProperty, isSpellCheckEnabled);
            return textBox;
        }
        public static T IsTextPredictionEnabled<T>(this T textBox, bool isTextPredictionEnabled) where T : TextBox
        {
            textBox.SetValue (TextBox.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
            return textBox;
        }
        public static T MaxLength<T>(this T textBox, int maxLength) where T : TextBox
        {
            textBox.SetValue (TextBox.MaxLengthProperty, maxLength);
            return textBox;
        }
        public static T PlaceholderForeground<T>(this T textBox, Brush placeholderForeground) where T : TextBox
        {
            textBox.SetValue (TextBox.PlaceholderForegroundProperty, placeholderForeground);
            return textBox;
        }

        public static T PlaceholderText<T>(this T textBox, string placeholderText) where T : TextBox
        {
            textBox.SetValue (TextBox.PlaceholderTextProperty, placeholderText);
            return textBox;
        }

        public static T PreventKeyboardDisplayOnProgrammaticFocus<T>(this T textBox, bool preventKeyboardDisplayOnProgrammaticFocus) where T : TextBox
        {
            textBox.SetValue (TextBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, preventKeyboardDisplayOnProgrammaticFocus);
            return textBox;
        }

        public static T ProofingMenuFlyout<T>(this T textBox, FlyoutBase proofingMenuFlyout) where T : TextBox
        {
            textBox.SetValue (TextBox.ProofingMenuFlyoutProperty, proofingMenuFlyout);
            return textBox;
        }

        public static T SelectionFlyout<T>(this T textBox, FlyoutBase selectionFlyout) where T : TextBox
        {
            textBox.SetValue (TextBox.SelectionFlyoutProperty, selectionFlyout);
            return textBox;
        }

        public static T SelectionHighlightColor<T>(this T textBox, SolidColorBrush selectionHighlightColor) where T : TextBox
        {
            textBox.SetValue (TextBox.SelectionHighlightColorProperty, selectionHighlightColor);
            return textBox;
        }

        public static T SelectionHighlightColorWhenNotFocused<T>(this T textBox, SolidColorBrush selectionHighlightColorWhenNotFocused) where T : TextBox
        {
            textBox.SetValue (TextBox.SelectionHighlightColorWhenNotFocusedProperty, selectionHighlightColorWhenNotFocused);
            return textBox;
        }

        public static T TextAlignment<T>(this T textBox, TextAlignment textAlignment) where T : TextBox
        {
            textBox.SetValue (TextBox.TextAlignmentProperty, textAlignment);
            return textBox;
        }

        public static T Text<T>(this T textBox, string text) where T : TextBox
        {
            textBox.SetValue (TextBox.TextProperty, text);
            return textBox;
        }

        public static T TextReadingOrder<T>(this T textBox, TextReadingOrder textReadingOrder) where T : TextBox
        {
            textBox.SetValue (TextBox.TextReadingOrderProperty, textReadingOrder);
            return textBox;
        }

        public static T TextWrapping<T>(this T textBox, TextWrapping textWrapping) where T : TextBox
        {
            textBox.SetValue (TextBox.TextWrappingProperty, textWrapping);
            return textBox;
        }

        public static T OnTextChanged<T>(this T textBox, TextChangedEventHandler action) where T : TextBox
        {
            textBox.TextChanged += action;
            return textBox;
        }

        public static T OnTextChanging<T>(this T textBox, TypedEventHandler<TextBox, TextBoxTextChangingEventArgs> action) where T : TextBox
        {
            textBox.TextChanging += action;
            return textBox;
        }
    }
}
