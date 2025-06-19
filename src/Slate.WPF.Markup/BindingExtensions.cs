using System.Windows.Data;

namespace Slate.WPF.Markup
{
    public static class BindingExtensions
    {
        public static T Link<T>(
                        this T control,
                        DependencyProperty property,
                        string path,
                        object source = null,
                        RelativeSource relativeSource = null,
                        UpdateSourceTrigger? updateSourceTrigger = null,
                        IValueConverter? converter = null) where T : FrameworkElement
        {
            var binding = new Binding (path);
            if (source != null)
            {
                binding.Source = source;
            }

            if (relativeSource != null)
            {
                binding.RelativeSource = relativeSource;
            }

            if (converter != null)
            {
                binding.Converter = converter;
            }

            if (updateSourceTrigger != null)
            {
                binding.UpdateSourceTrigger = updateSourceTrigger.Value;
            }

            return control.Binding (property, binding);
        }


        public static ContentControl Link(this ContentControl control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            return control.Binding (ContentControl.ContentProperty, binding);
        }
        public static TextBlock Link(this TextBlock control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            return control.Binding (TextBlock.TextProperty, binding);
        }
        public static ItemsControl Link(this ItemsControl control, string viewModelProperty)
        {
            return control.Binding (ItemsControl.ItemsSourceProperty, new Binding (viewModelProperty));
        }
        public static T Link<T>(this T control, string viewModelProperty) where T : ListBox
        {
            return control.Binding (ItemsControl.ItemsSourceProperty, new Binding (viewModelProperty));
        }
    }
}
