using System.Windows;
using System.Windows.Controls;
namespace FlexMVVM.WPF.Markup
{
    public static class UIElementExtensions
    {
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

        public static T AllowDrop<T>(this T element, bool allowDrop) where T : UIElement
        {
            element.SetValue (UIElement.AllowDropProperty, allowDrop);
            return element;
        }
        public static T Opacity<T>(this T element, double opacity) where T : UIElement
        {
            element.SetValue (UIElement.OpacityProperty, opacity);
            return element;
        }

        public static T Visibility<T>(this T element, Visibility visibility) where T : UIElement
        {
            element.SetValue (UIElement.VisibilityProperty, visibility);
            return element;
        }
        public static T Visibility<T>(this T element) where T : UIElement
        {
            return element;
        }
    }
}
