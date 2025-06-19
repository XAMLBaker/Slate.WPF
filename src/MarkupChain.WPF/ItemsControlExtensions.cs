using System.Collections;

namespace Slate.WPF.Markup
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
