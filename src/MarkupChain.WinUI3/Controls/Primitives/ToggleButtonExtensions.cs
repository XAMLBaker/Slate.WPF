namespace MarkupChain.WinUI3.Controls.Primitives;

public static class ToggleButtonExtensions
{
    public static T IsChecked<T>(this T toggleButton, bool? isChecked) where T : ToggleButton
    {
        toggleButton.SetValue(ToggleButton.IsCheckedProperty, isChecked);
        return toggleButton;
    }
    
    public static T IsThreeState<T>(this T toggleButton, bool isThreeState) where T : ToggleButton
    {
        toggleButton.SetValue(ToggleButton.IsThreeStateProperty, isThreeState);
        return toggleButton;
    }
}