using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;

namespace FlexMVVM.WPF.Markup
{
    public static class BindingExtensions
    {
        public static T Link<T>(
                        this T control,
                        DependencyProperty property,
                        string path,
                        object source = null,
                        IValueConverter? converter = null) where T : FrameworkElement
        {
            var binding = new Binding (path)
            {
                Source = source,
                Converter = converter
            };

            control.SetBinding (property, binding);
            return control;
        }


        public static ContentControl Link(this ContentControl control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            control.SetBinding (ContentControl.ContentProperty, binding);
            return control;
        }
        public static TextBlock Link(this TextBlock control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            control.SetBinding (TextBlock.TextProperty, binding);
            return control;
        }
        public static ItemsControl Link(this ItemsControl control, string viewModelProperty)
        {
            control.SetBinding (Selector.ItemsSourceProperty, new Binding (viewModelProperty));
            return control;
        }
    }
    public static class UIElementExtensions
    {
        public static T Children<T>(this T panel, params UIElement[] elements) where T : Panel
        {
            foreach (var element in elements)
            {
                panel.Children.Add (element);
            }
            return panel;
        }

        public static T SetDock<T>(this T cc, Dock dock) where T : FrameworkElement
        {
            DockPanel.SetDock(cc,dock);
            return cc;
        }

        public static T Row<T>(this T cc, int idx) where T : FrameworkElement
        {
            Grid.SetRow(cc,idx);
            return cc;
        }

        public static T Column<T>(this T cc, int idx) where T : FrameworkElement
        {
            Grid.SetColumn (cc, idx);
            return cc;
        }
    }

    public static class CommonElementExtentions
    {
        public static UIElement OnTapped(this UIElement element, Action action)
        {
            if (element.GetType ().BaseType == typeof (ButtonBase))
            {
                ((ButtonBase)element).Click += (_, __) => action ();
                return element;
            }
            element.MouseLeftButtonDown += (_, __) => action ();

            return element;
        }

        public static UIElement OnTappedAsync(this UIElement element, Func<Task> asyncAction)
        {
            element.MouseLeftButtonDown += async (_, __) => await asyncAction ();

            return element;
        }
    }

    public static class ControlExtentions
    {
        public static T Background<T>(this T ctrl, string colorString) where T : Control
        {
            ctrl.Background = new SolidColorBrush(ColorTool.Get (colorString));

            return ctrl;
        }

        public static T Width<T>(this T element, double value) where T : Control
        {
            element.Width = value;
            return element;
        }

        public static T Height<T>(this T element, double value) where T : Control
        {
            element.Height = value;
            return element;
        }

        public static T Background<T>(this T pnl, Color color) where T : Control
        {
            pnl.Background = new SolidColorBrush (color);

            return pnl;
        }
    }
    public static class PanelExtentions
    {
        public static T Width<T>(this T pnl, double value) where T : Panel
        {
            pnl.Width = value;
            return pnl;
        }

        public static T Height<T>(this T pnl, double value) where T : Panel
        {
            pnl.Height = value;
            return pnl;
        }
        public static T Background<T>(this T pnl, string colorString) where T : Panel
        {
            pnl.Background = new SolidColorBrush (ColorTool.Get (colorString));

            return pnl;
        }
        public static T Background<T>(this T pnl, Color color) where T : Panel
        {
            pnl.Background = new SolidColorBrush (color);

            return pnl;
        }
    }
}
