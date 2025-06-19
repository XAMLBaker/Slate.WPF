using System.Windows.Controls.Primitives;

namespace MarkupChain.WPF
{
    public static class PanelExtensions
    {
        public static T Background<T>(this T pnl, Brush color) where T : Panel
        {
            pnl.SetValue (Panel.BackgroundProperty, color);
            return pnl;
        }
        public static T Background<T>(this T pnl, Color color) where T : Panel
            => pnl.Background (BrushTool.Get (color));

        public static T Background<T>(this T pnl, string color) where T : Panel
            => pnl.Background (BrushTool.Get (color));

        public static T IsItemsHost<T>(this T pnl, bool isItemsHost) where T : Panel
        {
            pnl.SetValue (Panel.IsItemsHostProperty, isItemsHost);
            return pnl;
        }

        public static T ZIndex<T>(this T pnl, int index) where T : Panel
        {
            pnl.SetValue (Panel.ZIndexProperty, index);
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

        public static T Children<T>(this T panel, List<UIElement> elements) where T : Panel
        {
            return panel.Children(elements);
        }
    }

    public static class PanelCutomExtensions
    {
        public static T HasChild<T>(this T panel, List<UIElement> elements) where T : Panel
        {
            return panel.Children (elements);
        }
    }

    public static class UniformExtensions
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
