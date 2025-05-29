using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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

        public static T SetDock<T>(this T element, Dock dock) where T : UIElement
        {
            DockPanel.SetDock (element, dock);
            return element;
        }

        public static T Row<T>(this T element, int idx) where T : UIElement
        {
            Grid.SetRow (element, idx);
            return element;
        }

        public static T Column<T>(this T element, int idx) where T : UIElement
        {
            Grid.SetColumn (element, idx);
            return element;
        }

        public static T Background<T>(this T element, string color) where T : Control
        {
            element.Background(ColorTool.Get (color));

            return element;
        }
        public static T Background<T>(this T element, Color color) where T : Control
        {
            element.SetValue (Control.BackgroundProperty, new SolidColorBrush (color));
            return element;
        }
        public static T Foreground<T>(this T element, string color) where T : Control
        {
            element.Foreground(ColorTool.Get (color));

            return element;
        }
        public static T Foreground<T>(this T element, Color color) where T : Control
        {
            element.SetValue (Control.ForegroundProperty, new SolidColorBrush (color));

            return element;
        }

        public static T FontSize<T>(this T element, double size) where T : Control
        {
            element.SetValue (Control.FontSizeProperty, size);

            return element;
        }

        public static T FontFamliy<T>(this T element, FontFamily fontFamliy) where T : Control
        {
            element.SetValue (Control.FontFamilyProperty, fontFamliy);
            return element;
        }

        public static T FontWeight<T>(this T element, FontWeight size) where T : Control
        {
            element.SetValue (Control.FontWeightProperty, size);
            return element;
        }
        public static T FontStyle<T>(this T element, FontStyle style) where T : Control
        {
            element.SetValue (Control.FontStyleProperty, style);

            return element;
        }
        public static T FontStretch<T>(this T element, FontStretch stretch) where T : Control
        {
            element.SetValue (Control.FontStretchProperty, stretch);

            return element;
        }
        public static T BorderBrush<T>(this T element, string colorString) where T : Control
        {
            return element.BorderBrush (ColorTool.Get (colorString));
        }
        public static T BorderBrush<T>(this T element, Color color) where T : Control
        {
             element.SetValue (Control.BorderBrushProperty, new SolidColorBrush (color));

            return element;
        }

        public static T BorderThickness<T>(this T element, double marginAll = 0) where T : Control
        {
            return element.BorderThickness (new Thickness (marginAll, marginAll, marginAll, marginAll));
        }
        public static T BorderThickness<T>(this T element, double leftright = 0, double topbottom = 0) where T : Control
        {
            return element.BorderThickness (new Thickness (leftright, topbottom, leftright, topbottom));
        }
        public static T BorderThickness<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
        {
            return element.BorderThickness (new Thickness (left, top, right, bottom));
        }
        public static T BorderThickness<T>(this T element, Thickness value) where T : Control
        {
            if (value == null)
                return element;
            element.SetValue (Control.BorderThicknessProperty, value);

            return element;
        }
        public static T Padding<T>(this T element, double marginAll = 0) where T : Control
        {
            return element.Padding (new Thickness (marginAll, marginAll, marginAll, marginAll));
        }
        public static T Padding<T>(this T element, double leftright = 0, double topbottom = 0) where T : Control
        {
            return element.Padding (new Thickness (leftright, topbottom, leftright, topbottom));
        }
        public static T Padding<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
        {
            return element.Padding(new Thickness (left, top, right, bottom));
        }
        public static T Padding<T>(this T element, Thickness thickness) where T : Control
        {
            if (thickness == null)
                return element;
            element.SetValue (Control.PaddingProperty, thickness);
            return element;
        }

       
    }
}
