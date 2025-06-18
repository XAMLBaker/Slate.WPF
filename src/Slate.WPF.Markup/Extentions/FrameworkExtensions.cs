using System.Windows;
using System.Windows.Input;
namespace Slate.WPF.Markup
{
    public static partial class FrameworkExtensions
    {
        public static T Name<T>(this T fe, object value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.NameProperty, value);
            return fe;
        }
        public static T Margin<T>(this T fe, Thickness thickness) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MarginProperty, thickness);
            return fe;
        }
        
        public static T VCenter<T>(this T fe) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);
            return fe;
        }
        public static T HCenter<T>(this T fe) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            return fe;
        }
        public static T Left<T>(this T fe) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Left);
            return fe;
        }
        public static T Right<T>(this T fe) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Right);
            return fe;
        }
        public static T Top<T>(this T fe) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Top);
            return fe;
        }
        public static T Bottom<T>(this T fe) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Bottom);
            return fe;
        }

        public static T MinWidth<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.SetValue(FrameworkElement.MinWidthProperty, value);
            return fe;
        }
        public static T MaxWidth<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MaxWidthProperty, value);
            return fe;
        }
        public static T MinHeight<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MinHeightProperty, value);
            return fe;
        }
        public static T MaxHeight<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.MaxHeightProperty, value);

            return fe;
        }
        public static T Tag<T>(this T fe, object value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.TagProperty, value);
            return fe;
        }

        public static T UseLayoutRounding<T>(this T fe) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.UseLayoutRoundingProperty, true);
            return fe;
        }
        public static T Width<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.WidthProperty, value);
            return fe;
        }

        public static T Height<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.HeightProperty, value);
            return fe;
        }
        public static T  Cursor<T>(this T fe, Cursor value) where T : FrameworkElement
        {
            fe.SetValue (FrameworkElement.CursorProperty, value);
            return fe;
        }
    }
}
