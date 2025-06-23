using System.Windows.Controls.Primitives;
using System.Windows.Data;


namespace Slate.WPF.Markup
{
    public static partial class ButtonExtensions
    {
        public static T IsChecked<T>(this T tb, IState state) where T : ToggleButton
        {
            return tb.Binding (ToggleButton.IsCheckedProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T IsThreeState<T>(this T tb, IState state) where T : ToggleButton
        {
            return tb.Binding (ToggleButton.IsThreeStateProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
    }
}
