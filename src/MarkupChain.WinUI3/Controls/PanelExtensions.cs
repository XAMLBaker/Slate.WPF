using Windows.UI;

namespace MarkupChain.WinUI3.Controls
{
    public static partial class PanelExtensions
    {
        public static T Background<T>(this T panel, Color color) where T : Panel
        {
            panel.Background (BrushTool.Get (color));
            return panel;
        }
        public static T Background<T>(this T panel, string color) where T : Panel
        {
            panel.Background(BrushTool.Get(color));
            return panel;
        }

        public static T Children<T>(this T panel, params FrameworkElement[] elements) where T :Panel
        {
            foreach(var children in elements)
            {
                panel.Children.Add (children);
            }

            return panel;
        }
    }
}
