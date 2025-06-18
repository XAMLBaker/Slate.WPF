using System.Windows.Controls.Primitives;

namespace Slate.WPF.Markup
{
    public static class ButtonExtensions
    {
    }
    public static class TogglButtonExtensions
    {

        public static T IsChecked<T> (this T tb, bool? isChcked) where T : ToggleButton
        {
            tb.SetValue (ToggleButton.IsCheckedProperty, isChcked);
            return tb;
        }
        public static T IsThreeState<T>(this T tb, bool isThreeState) where T : ToggleButton
        {
            tb.SetValue (ToggleButton.IsThreeStateProperty, isThreeState);
            return tb;
        }
    }
}
