using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public static class DecoratorExtnetions
    {
        public static T Child<T>(this T fe, UIElement element) where T : Decorator
        {
            fe.Child = element;
            return fe;
        }
    }
}
