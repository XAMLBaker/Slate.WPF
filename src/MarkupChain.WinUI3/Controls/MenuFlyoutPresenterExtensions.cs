namespace MarkupChain.WinUI3.Controls;

public static class MenuFlyoutPresenterExtensions
{
    public static T IsDefaultShadowEnabled<T>(this T presenter, bool menuFlyout) where T : MenuFlyoutPresenter
    {
        presenter.SetValue(MenuFlyoutPresenter.IsDefaultShadowEnabledProperty, menuFlyout);
        return presenter;
    }

    public static T SystemBackdrop<T>(this T presenter, SystemBackdrop systemBackdrop) where T : MenuFlyoutPresenter
    {
        presenter.SetValue(MenuFlyoutPresenter.SystemBackdropProperty, systemBackdrop);
        return presenter;
    }
}