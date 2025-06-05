using System.Collections;
using System.Windows.Controls;

namespace FlexMVVM.WPF.Markup.Extentions
{
    public static class ItemsControlExtentions
    {
        public static T ItemsSource<T>(this T Ic, IEnumerable itemSource) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemsSourceProperty, itemSource);
            return Ic;
        }
    }
}
