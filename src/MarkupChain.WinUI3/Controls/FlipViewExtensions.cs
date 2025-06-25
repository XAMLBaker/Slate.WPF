namespace MarkupChain.WinUI3.Controls;

public static class FlipViewExtensions
{
    public static T UseTouchAnimationsForAllNavigation<T>(this T flipView, bool useTouchAnimations) where T : FlipView
    {
        flipView.SetValue(FlipView.UseTouchAnimationsForAllNavigationProperty, useTouchAnimations);
        return flipView;
    }
}