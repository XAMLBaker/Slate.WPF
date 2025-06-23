using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
namespace MarkupChain.WPF
{
    public static partial class FrameworkExtensions
    {
        public static T ActualHeight<T>(this T fe, double actualHeight) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.ActualHeightProperty, actualHeight);
            return fe;
        }
        public static T MaxWidth<T>(this T fe, double maxWidth) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MaxWidthProperty, maxWidth);
            return fe;
        }
        public static T MinHeight<T>(this T fe, double minHeight) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MinHeightProperty, minHeight);
            return fe;
        }

        public static T MinWidth<T>(this T fe, double minWidth) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MinWidthProperty, minWidth);
            return fe;
        }

        public static T Name<T>(this T fe, string name) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.NameProperty, name);
            return fe;
        }

        public static T OverridesDefaultStyle<T>(this T fe, bool overridesDefaultStyle) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.OverridesDefaultStyleProperty, overridesDefaultStyle);
            return fe;
        }
        public static T Style<T>(this T fe, Style style) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.StyleProperty, style);
            return fe;
        }
        public static T ToolTip<T>(this T fe, object toolTip) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.ToolTipProperty, toolTip);
            return fe;
        }

        public static T UseLayoutRounding<T>(this T fe, bool useLayoutRounding=true) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.UseLayoutRoundingProperty, useLayoutRounding);
            return fe;
        }

        public static T VerticalAlignment<T>(this T fe, VerticalAlignment verticalAlignment) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.VerticalAlignmentProperty, verticalAlignment);
            return fe;
        }

        public static T Width<T>(this T fe, double width) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.WidthProperty, width);
            return fe;
        }
        public static T MaxHeight<T>(this T fe, double maxHeight) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MaxHeightProperty, maxHeight);

            return fe;
        }

        public static T Margin<T>(this T fe, Thickness margin) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MarginProperty, margin);
            return fe;
        }

        public static T Tag<T>(this T fe, object tag) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.TagProperty, tag);
            return fe;
        }

        public static T LayoutTransform<T>(this T fe, Transform layoutTransform) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.LayoutTransformProperty, layoutTransform);
            return fe;
        }

        public static T ActualWidth<T>(this T fe, double actualWidth) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.ActualWidthProperty, actualWidth);
            return fe;
        }

        public static T BindingGroup<T>(this T fe, BindingGroup bindingGroup) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.BindingGroupProperty, bindingGroup);
            return fe;
        }

        public static T ContextMenu<T>(this T fe, ContextMenu contextMenu) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.ContextMenuProperty, contextMenu);
            return fe;
        }

        public static T Cursor<T>(this T fe, Cursor cursor) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.CursorProperty, cursor);
            return fe;
        }
        public static T DataContext<T>(this T fe, object dataContext) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.DataContextProperty, dataContext);
            return fe;
        }
        public static T FlowDirection<T>(this T fe, FlowDirection flowDirection) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.FlowDirectionProperty, flowDirection);
            return fe;
        }

        public static T ForceCursor<T>(this T fe, bool forceCursor) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.ForceCursorProperty, forceCursor);
            return fe;
        }

        public static T Height<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.HeightProperty, value);
            return fe;
        }

        public static T HorizontalAlignment<T>(this T fe, HorizontalAlignment horizontalAlignment) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.HorizontalAlignmentProperty, horizontalAlignment);
            return fe;
        }

        public static T InputScope<T>(this T fe, InputScope inputScope) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.InputScopeProperty, inputScope);
            return fe;
        }

        public static T Language<T>(this T fe, XmlLanguage language) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.LanguageProperty, language);
            return fe;
        }
    }
}
