using Windows.Foundation;

namespace MarkupChain.WinUI3.Controls
{
    public static class TabViewExtensions
    {
        public static T AllowDropTabs<T>(this T pivot, bool allowDropTabs) where T : TabView
        {
            pivot.SetValue (TabView.AllowDropTabsProperty, allowDropTabs);
            return pivot;
        }

        public static T CanDragTabs<T>(this T pivot, bool canDragTabs) where T : TabView
        {
            pivot.SetValue (TabView.CanDragTabsProperty, canDragTabs);
            return pivot;
        }
        public static T CanReorderTabs<T>(this T pivot, bool canReorderTabs) where T : TabView
        {
            pivot.SetValue (TabView.CanReorderTabsProperty, canReorderTabs);
            return pivot;
        }
        public static T CanTearOutTabs<T>(this T pivot, bool canTearOutTabs) where T : TabView
        {
            pivot.SetValue (TabView.CanTearOutTabsProperty, canTearOutTabs);
            return pivot;
        }
        public static T CloseButtonOverlayMode<T>(this T pivot, TabViewCloseButtonOverlayMode closeButtonOverlayMode) where T : TabView
        {
            pivot.SetValue (TabView.CloseButtonOverlayModeProperty, closeButtonOverlayMode);
            return pivot;
        }
        public static T IsAddTabButtonVisible<T>(this T pivot, bool isAddTabButtonVisible) where T : TabView
        {
            pivot.SetValue (TabView.IsAddTabButtonVisibleProperty, isAddTabButtonVisible);
            return pivot;
        }
        public static T SelectedIndex<T>(this T pivot, int selectedIndex) where T : TabView
        {
            pivot.SetValue (TabView.SelectedIndexProperty, selectedIndex);
            return pivot;
        }
        public static T SelectedItem<T>(this T pivot, object selectedItem) where T : TabView
        {
            pivot.SetValue (TabView.SelectedItemProperty, selectedItem);
            return pivot;
        }
        public static T TabStripFooter<T>(this T pivot, object tabStripFooter) where T : TabView
        {
            pivot.SetValue (TabView.TabStripFooterProperty, tabStripFooter);
            return pivot;
        }
        public static T TabStripHeader<T>(this T pivot, object tabStripHeader) where T : TabView
        {
            pivot.SetValue (TabView.TabStripHeaderProperty, tabStripHeader);
            return pivot;
        }
        public static T TabWidthMode<T>(this T pivot, TabViewWidthMode tabWidthMode) where T : TabView
        {
            pivot.SetValue (TabView.TabWidthModeProperty, tabWidthMode);
            return pivot;
        }

        public static T OnAddTab<T>(this T pivot, TypedEventHandler<TabView, object> action ) where T : TabView
        {
            pivot.AddTabButtonClick += action;
            return pivot;
        }
        public static T OnTabClosed<T>(this T pivot, TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> action) where T : TabView
        {
            pivot.TabCloseRequested += action;
            return pivot;
        }
    }
}
