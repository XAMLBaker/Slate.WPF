using System.Windows.Controls.Primitives;

namespace MarkupChain.WPF
{
    public static partial class PanelExtensions
    {
        public static T Background<T>(this T pnl, Brush color) where T : Panel
        {
            pnl.SetValue (Panel.BackgroundProperty, color);
            return pnl;
        }

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
    }

    public static class WrapPanelExtensions
    {
        public static T ItemHeight<T>(this T pnl, double itemHeight) where T : WrapPanel
        {
            pnl.SetValue (WrapPanel.ItemHeightProperty, itemHeight);
            return pnl;
        }

        public static T ItemWidth<T>(this T pnl, double itemWidth) where T : WrapPanel
        {
            pnl.SetValue (WrapPanel.ItemWidthProperty, itemWidth);
            return pnl;
        }

        public static T Orientation<T>(this T pnl, Orientation orientation) where T : WrapPanel
        {
            pnl.SetValue (WrapPanel.OrientationProperty, orientation);
            return pnl;
        }
    }

    public static class DockPanelExtensions
    {
        public static T LastChildFill<T>(this T pnl, bool lastChildFill) where T : DockPanel
        {
            pnl.SetValue (DockPanel.LastChildFillProperty, lastChildFill);
            return pnl;
        }
    }

    public static class UniformGridExtensions
    {
        public static T Columns<T>(this T pnl, int columnCount) where T : UniformGrid
        {
            pnl.SetValue(UniformGrid.ColumnsProperty, columnCount);
            return pnl;
        }
        public static T Rows<T>(this T pnl, int rowCount) where T : UniformGrid
        {
            pnl.SetValue (UniformGrid.RowsProperty, rowCount);
            return pnl;
        }

        public static T FirstColumn<T>(this T pnl, int firstColumn) where T : UniformGrid
        {
            pnl.SetValue (UniformGrid.FirstColumnProperty, firstColumn);
            return pnl;
        }
    }
    public static class StackPanelExtensions
    {
        public static T Orientation<T>(this T sp, Orientation orientation) where T : StackPanel
        {
            sp.SetValue (StackPanel.OrientationProperty, orientation);
            return sp;
        }
    }
}