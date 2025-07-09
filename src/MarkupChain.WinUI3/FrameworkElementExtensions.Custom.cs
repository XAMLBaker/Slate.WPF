using System.Threading.Tasks;

namespace MarkupChain.WinUI3
{
    public static partial class FrameworkElementExtensions
    {
        public static T Size<T>(this T element, double width, double height)
            where T : FrameworkElement
        {
            return element.Width(width)
                          .Height(height);
        }


        public static T Row<T>(this T element, int idx) where T : FrameworkElement
        {
            Grid.SetRow (element, idx);
            return element;
        }

        public static T RowSpan<T>(this T element, int value) where T : FrameworkElement
        {
            Grid.SetRowSpan (element, value);
            return element;
        }

        public static T Column<T>(this T element, int idx) where T : FrameworkElement
        {
            Grid.SetColumn (element, idx);
            return element;
        }
        public static T ColumnSpan<T>(this T element, int value) where T : FrameworkElement
        {
            Grid.SetColumnSpan (element, value);
            return element;
        }
    }
}
