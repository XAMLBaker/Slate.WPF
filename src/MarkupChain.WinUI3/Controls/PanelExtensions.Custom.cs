namespace MarkupChain.WinUI3.Controls
{
    public static partial class PanelExtensions
    {
        public static T Background<T>(this T panel, Brush color) where T : Panel
        {
            panel.SetValue (Panel.BackgroundProperty, color);
            return panel;
        }
        public static T ChildrenTransitions<T>(this T panel, TransitionCollection transitionCollection) where T : Panel
        {
            panel.SetValue (Panel.ChildrenTransitionsProperty, transitionCollection);
            return panel;
        }
        public static T IsItemsHost<T>(this T panel, bool isItemsHost) where T : Panel
        {
            panel.SetValue (Panel.IsItemsHostProperty, isItemsHost);
            return panel;
        }
    }
}
