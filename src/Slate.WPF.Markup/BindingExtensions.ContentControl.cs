using System.Windows.Data;


namespace Slate.WPF.Markup
{
    public static partial class BindingExtensions
    {
        public static T Content<T>(this T control, IState state) where T : ContentControl
        {
            return control.Binding (ContentControl.ContentProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
    }
}
