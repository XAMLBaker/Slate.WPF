using System.Windows.Data;

namespace MarkupChain.WPF
{
    public static class BindingExtensions
    {
        public static T Binding<T>(this T control, DependencyProperty property, string path) where T : FrameworkElement
        {
            var binding = new Binding (path);
            control.SetBinding (property, binding);

            return control;
        }

        public static T Binding<T>(this T control, DependencyProperty property, BindingBase bindingBase) where T : FrameworkElement
        {
            control.SetBinding (property, bindingBase);

            return control;
        }
    }
}
