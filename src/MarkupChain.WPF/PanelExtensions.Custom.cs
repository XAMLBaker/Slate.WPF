using System.Windows.Controls.Primitives;

namespace MarkupChain.WPF
{
    public static partial class PanelExtensions
    {
        public static T Background<T>(this T pnl, Color color) where T : Panel
            => pnl.Background (BrushTool.Get (color));

        public static T Background<T>(this T pnl, string color) where T : Panel
            => pnl.Background (BrushTool.Get (color));

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
        public static T HasChild<T>(this T panel, List<UIElement> elements) where T : Panel
        {
            return panel.Children (elements);
        }
    }
}
