using System.Windows.Controls.Primitives;

namespace FlexMVVM.WPF.Markup.Extentions
{
    public static class ButtonExtentions
    {
    }
    public static class TogglButtonExtentions
    {

        public static T IsChecked<T> (this T tb, bool isChcked) where T : ToggleButton
        {
            tb.SetValue (ToggleButton.IsCheckedProperty, isChcked);
            return tb;
        }
        public static T IsThreeState<T>(this T tb, bool? isThreeState) where T : ToggleButton
        {
            tb.SetValue (ToggleButton.IsThreeStateProperty, isThreeState);
            return tb;
        }
    }
}
