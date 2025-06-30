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
    }
}
