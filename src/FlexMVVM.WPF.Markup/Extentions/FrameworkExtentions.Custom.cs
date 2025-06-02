using System.Windows;
using System.Windows.Input;
namespace FlexMVVM.WPF.Markup
{
    public static partial class FrameworkExtentions
    {
        public static T Size<T>(this T fe, double width, double height) where T : FrameworkElement
        {
            fe.Width (width);
            fe.Height (height);
            return fe;
        }
    }
}
