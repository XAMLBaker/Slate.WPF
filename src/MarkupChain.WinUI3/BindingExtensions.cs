using Microsoft.UI.Xaml.Data;

namespace MarkupChain.WinUI3
{
    public static class BindingExtensions
    {
        public static T Binding<T>(this T control, DependencyProperty property, string path, BindingMode bindingMode= BindingMode.TwoWay) where T : FrameworkElement
        {
            var binding = new Binding ();
            binding.Path = new PropertyPath(path);
            binding.Mode = bindingMode;
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
