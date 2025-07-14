using Windows.Foundation;

namespace MarkupChain.WinUI3.Controls
{
    public static partial class RichEditBoxExtensions
    {
        public static T AcceptsReturn<T>(this T richEditBox, bool acceptsReturn) where T : RichEditBox
        {
            richEditBox.SetValue(RichEditBox.AcceptsReturnProperty, acceptsReturn);
            return richEditBox;
        }
        public static T CharacterCasing<T>(this T richEditBox, CharacterCasing characterCasing) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.CharacterCasingProperty, characterCasing);
            return richEditBox;
        }
        public static T ClipboardCopyFormat<T>(this T richEditBox, RichEditClipboardFormat clipboardCopyFormat) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.ClipboardCopyFormatProperty, clipboardCopyFormat);
            return richEditBox;
        }
        public static T Description<T>(this T richEditBox, object description) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.DescriptionProperty, description);
            return richEditBox;
        }

        public static T DesiredCandidateWindowAlignment<T>(this T richEditBox, CandidateWindowAlignment desiredCandidateWindowAlignment) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.DesiredCandidateWindowAlignmentProperty, desiredCandidateWindowAlignment);
            return richEditBox;
        }

        public static T DisabledFormattingAccelerators<T>(this T richEditBox, DisabledFormattingAccelerators disabledFormattingAccelerators) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.DisabledFormattingAcceleratorsProperty, disabledFormattingAccelerators);
            return richEditBox;
        }

        public static T Header<T>(this T richEditBox, object header) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.HeaderProperty, header);
            return richEditBox;
        }
        public static T HorizontalTextAlignment<T>(this T richEditBox, TextAlignment horizontalTextAlignment) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return richEditBox;
        }
        public static T InputScope<T>(this T richEditBox, InputScope inputScope) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.InputScopeProperty, inputScope);
            return richEditBox;
        }
        public static T IsColorFontEnabled<T>(this T richEditBox, bool isColorFontEnabled) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.IsColorFontEnabledProperty, isColorFontEnabled);
            return richEditBox;
        }
        public static T IsReadOnly<T>(this T richEditBox, bool isReadOnly) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.IsReadOnlyProperty, isReadOnly);
            return richEditBox;
        }
        public static T IsSpellCheckEnabled<T>(this T richEditBox, bool isSpellCheckEnabled) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.IsSpellCheckEnabledProperty, isSpellCheckEnabled);
            return richEditBox;
        }
        public static T IsTextPredictionEnabled<T>(this T richEditBox, bool isTextPredictionEnabled) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
            return richEditBox;
        }
        public static T MaxLength<T>(this T richEditBox, int maxLength) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.MaxLengthProperty, maxLength);
            return richEditBox;
        }
        public static T PlaceholderText<T>(this T richEditBox, string placeholderText) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.PlaceholderTextProperty, placeholderText);
            return richEditBox;
        }
        public static T PreventKeyboardDisplayOnProgrammaticFocus<T>(this T richEditBox, bool preventKeyboardDisplayOnProgrammaticFocus) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.PreventKeyboardDisplayOnProgrammaticFocusProperty, preventKeyboardDisplayOnProgrammaticFocus);
            return richEditBox;
        }
        public static T SelectionFlyout<T>(this T richEditBox, FlyoutBase selectionFlyout) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.SelectionFlyoutProperty, selectionFlyout);
            return richEditBox;
        }

        public static T SelectionHighlightColor<T>(this T richEditBox, SolidColorBrush selectionHighlightColor) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.SelectionHighlightColorProperty, selectionHighlightColor);
            return richEditBox;
        }

        public static T SelectionHighlightColorWhenNotFocused<T>(this T richEditBox, SolidColorBrush selectionHighlightColorWhenNotFocused) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.SelectionHighlightColorWhenNotFocusedProperty, selectionHighlightColorWhenNotFocused);
            return richEditBox;
        }
        public static T TextAlignment<T>(this T richEditBox, TextAlignment textAlignment) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.TextAlignmentProperty, textAlignment);
            return richEditBox;
        }
        public static T TextReadingOrder<T>(this T richEditBox, TextReadingOrder textReadingOrder) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.TextReadingOrderProperty, textReadingOrder);
            return richEditBox;
        }
        public static T TextWrapping<T>(this T richEditBox, TextWrapping textWrapping) where T : RichEditBox
        {
            richEditBox.SetValue (RichEditBox.TextWrappingProperty, textWrapping);
            return richEditBox;
        }

        public static T OnTextChanged<T>(this T richEditBox, RoutedEventHandler action) where T : RichEditBox
        {
            richEditBox.TextChanged += action;
            return richEditBox;
        }

        public static T OnTextChanging<T>(this T richEditBox, TypedEventHandler<RichEditBox, RichEditBoxTextChangingEventArgs> action) where T : RichEditBox
        {
            richEditBox.TextChanging += action;
            return richEditBox;
        }
    }
}
