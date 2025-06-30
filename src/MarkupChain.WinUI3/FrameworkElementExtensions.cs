namespace MarkupChain.WinUI3
{
    //an extension class which able to chaining -Property(=DependencyProperty) affix Properties.
    public static partial class FrameworkElementExtensions
    {
        public static T FlowDirection<T>(this T element, FlowDirection direction) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.FlowDirectionProperty, direction);
            return element;
        }

        public static T Height<T>(this T element, double height) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.HeightProperty, height);
            return element;
        }

        public static T Width<T>(this T element, double width) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.WidthProperty, width);
            return element;
        }

        public static T MinHeight<T>(this T element, double minHeight) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.MinHeightProperty, minHeight);
            return element;
        }

        public static T MinWidth<T>(this T element, double minWidth) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.MinWidthProperty, minWidth);
            return element;
        }

        public static T MaxHeight<T>(this T element, double maxHeight) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.MaxHeightProperty, maxHeight);
            return element;
        }

        public static T MaxWidth<T>(this T element, double maxWidth) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.MaxWidthProperty, maxWidth);
            return element;
        }

        public static T Margin<T>(this T element, Thickness margin) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.MarginProperty, margin);
            return element;
        }

        public static T HorizontalAlignment<T>(this T element, HorizontalAlignment alignment) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.HorizontalAlignmentProperty, alignment);
            return element;
        }

        public static T VerticalAlignment<T>(this T element, VerticalAlignment alignment) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.VerticalAlignmentProperty, alignment);
            return element;
        }

        public static T Language<T>(this T element, string languageString) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.LanguageProperty, languageString);
            return element;
        }

        public static T Style<T>(this T element, Style style) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.StyleProperty, style);
            return element;
        }

        public static T DataContext<T>(this T element, object dataContext) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.DataContextProperty, dataContext);
            return element;
        }

        public static T Tag<T>(this T element, object tag) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.TagProperty, tag);
            return element;
        }

        public static T Name<T>(this T element, string name) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.NameProperty, name);
            return element;
        }

        public static T AllowFocusOnInteraction<T>(this T element, bool allowFocusOnInteraction)
            where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.AllowFocusOnInteractionProperty, allowFocusOnInteraction);
            return element;
        }

        public static T RequestedTheme<T>(this T element, ElementTheme requestedTheme) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.RequestedThemeProperty, requestedTheme);
            return element;
        }

        public static T FocusVisualMargin<T>(this T element, Thickness focusVisualMargin) where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.FocusVisualMarginProperty, focusVisualMargin);
            return element;
        }

        public static T FocusVisualPrimaryThickness<T>(this T element, Thickness focusVisualPrimaryThickness)
            where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.FocusVisualPrimaryThicknessProperty, focusVisualPrimaryThickness);
            return element;
        }

        public static T FocusVisualSecondaryThickness<T>(this T element, Thickness focusVisualSecondaryThickness)
            where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.FocusVisualSecondaryThicknessProperty, focusVisualSecondaryThickness);
            return element;
        }

        public static T AllowFocusWhenDisabled<T>(this T element, bool allowFocusWhenDisabled)
            where T : FrameworkElement
        {
            element.SetValue(FrameworkElement.AllowFocusWhenDisabledProperty, allowFocusWhenDisabled);
            return element;
        }
    }
}
