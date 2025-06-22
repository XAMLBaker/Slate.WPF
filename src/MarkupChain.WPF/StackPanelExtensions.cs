namespace MarkupChain.WPF
{
    public static class StackPanelExtensions
    {
        public static T Orientation<T>(this T sp, Orientation orientation) where T : StackPanel
        {
            sp.SetValue (StackPanel.OrientationProperty, orientation);
            return sp;
        }
    }
}
