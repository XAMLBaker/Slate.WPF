using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace FlexMVVM.WPF
{
    public static class PanelExtentions
    {

        public static T Background<T>(this T pnl, Color color) where T : Panel
        {
            pnl.Background = new SolidColorBrush (color);
            return pnl;
        }

        public static T Background<T>(this T pnl, string color) where T : Panel
        {
            pnl.Background (ColorTool.Get (color));

            return pnl;
        }
        public static T Children<T>(this T panel, params UIElement[] elements) where T : Panel
        {
            foreach (var element in elements)
            {
                panel.Children.Add (element);
            }
            return panel;
        }
    }
    public static class UniformExtentions
    {
        public static T Columns<T>(this T panel, int columnCount) where T : UniformGrid
        {
            panel.Columns = columnCount;
            return panel;
        }
        public static T Rows<T>(this T panel, int columnCount) where T : UniformGrid
        {
            panel.Rows = columnCount;
            return panel;
        }

        public static T FirstColumn<T>(this T panel, int startColumnIndex) where T : UniformGrid
        {
            panel.FirstColumn = startColumnIndex;
            return panel;
        }
    }
}
