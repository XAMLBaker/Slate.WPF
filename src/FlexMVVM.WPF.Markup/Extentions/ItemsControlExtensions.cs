using System.Collections;
using System.Windows.Controls;

namespace FlexMVVM.WPF.Markup.Extensions
{
    public static class ItemsControlExtensions
    {
        public static T ItemsSource<T>(this T Ic, IEnumerable itemSource) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemsSourceProperty, itemSource);
            return Ic;
        }
    }
}
