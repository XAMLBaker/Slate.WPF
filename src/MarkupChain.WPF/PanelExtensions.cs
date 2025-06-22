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

    public static class UniformExtensions
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
}
