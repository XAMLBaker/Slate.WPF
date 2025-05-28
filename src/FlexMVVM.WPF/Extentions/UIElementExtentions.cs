using System.Windows;
using System.Windows.Controls;
namespace FlexMVVM.WPF
{
    public static class UIElementExtentions
    {
        public static T Margin<T>(this T element, Thickness thickness) where T : UIElement
        {
            element.SetValue (FrameworkElement.MarginProperty, thickness);
            return element;
        }
        public static T Margin<T>(this T element, double marginAll = 0) where T : UIElement
        {
            var temp = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return element.Margin (temp);
        }
        public static T Margin<T>(this T element, double leftright = 0, double topbottom = 0) where T : UIElement
        {
            var temp = new Thickness (leftright, topbottom, leftright, topbottom);
            return element.Margin (temp);
        }
        public static T Margin<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : UIElement
        {
            var temp = new Thickness (left, top, right, bottom);
            return element.Margin (temp);
        }
        public static T Center<T>(this T element) where T : UIElement
        {
            element.VCenter ();
            element.HCenter ();
            return element;
        }

        public static T VCenter<T>(this T element) where T : UIElement
        {
            element.SetValue (FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);
            return element;
        }
        public static T HCenter<T>(this T element) where T : UIElement
        {
            element.SetValue (FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            return element;
        }
        public static T Left<T>(this T element) where T : UIElement
        {
            element.SetValue (FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Left);
            return element;
        }
        public static T Right<T>(this T element) where T : UIElement
        {
            element.SetValue (FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Right);
            return element;
        }
        public static T Top<T>(this T element) where T : UIElement
        {
            element.SetValue (FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Top);
            return element;
        }
        public static T Bottom<T>(this T element) where T : UIElement
        {
            element.SetValue (FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Bottom);
            return element;
        }

        public static T MinWidth<T>(this T element, double value) where T : UIElement
        {
            element.SetValue(FrameworkElement.MinWidthProperty, value);
            return element;
        }
        public static T MaxWidth<T>(this T element, double value) where T : UIElement
        {
            element.SetValue (FrameworkElement.MaxWidthProperty, value);
            return element;
        }
        public static T MinHeight<T>(this T element, double value) where T : UIElement
        {
            element.SetValue (FrameworkElement.MinHeightProperty, value);
            return element;
        }
        public static T MaxHeight<T>(this T element, double value) where T : UIElement
        {
            element.SetValue (FrameworkElement.MaxHeightProperty, value);

            return element;
        }
        public static T Tag<T>(this T element, object value) where T : UIElement
        {
            element.SetValue (FrameworkElement.TagProperty, value);
            return element;
        }

        public static T UseLayoutRounding<T>(this T element) where T : UIElement
        {
            element.SetValue (FrameworkElement.UseLayoutRoundingProperty, true);
            return element;
        }
        public static T Width<T>(this T element, double value) where T : UIElement
        {
            element.SetValue (FrameworkElement.WidthProperty, value);
            return element;
        }

        public static T Height<T>(this T element, double value) where T : UIElement
        {
            element.SetValue (FrameworkElement.HeightProperty, value);
            return element;
        }

        public static T SetDock<T>(this T fe, Dock dock) where T : UIElement
        {
            DockPanel.SetDock (fe, dock);
            return fe;
        }

        public static T Row<T>(this T fe, int idx) where T : UIElement
        {
            Grid.SetRow (fe, idx);
            return fe;
        }

        public static T Column<T>(this T fe, int idx) where T : UIElement
        {
            Grid.SetColumn (fe, idx);
            return fe;
        }
    }
}
