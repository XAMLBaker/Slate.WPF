using System.Windows.Controls;

namespace Slate.WPF.Markup
{
    public static class StackPanelExtensions
    {
        public static T Orientation<T>(this T fp, Orientation orientation) where T : StackPanel
        {
            fp.Orientation = orientation;
            return fp;
        }

    }
}
