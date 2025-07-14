using System;
using System.Linq;
using Windows.Foundation;

namespace MarkupChain.WinUI3.Controls
{
    public static class TabViewExtensions
    {
        public static T AllowDropTabs<T>(this T tabView, bool allowDropTabs) where T : TabView
        {
            tabView.SetValue (TabView.AllowDropTabsProperty, allowDropTabs);
            return tabView;
        }

        public static T CanDragTabs<T>(this T tabView, bool canDragTabs) where T : TabView
        {
            tabView.SetValue (TabView.CanDragTabsProperty, canDragTabs);
            return tabView;
        }
        public static T CanReorderTabs<T>(this T tabView, bool canReorderTabs) where T : TabView
        {
            tabView.SetValue (TabView.CanReorderTabsProperty, canReorderTabs);
            return tabView;
        }
        public static T CanTearOutTabs<T>(this T tabView, bool canTearOutTabs) where T : TabView
        {
            tabView.SetValue (TabView.CanTearOutTabsProperty, canTearOutTabs);
            return tabView;
        }
        public static T CloseButtonOverlayMode<T>(this T tabView, TabViewCloseButtonOverlayMode closeButtonOverlayMode) where T : TabView
        {
            tabView.SetValue (TabView.CloseButtonOverlayModeProperty, closeButtonOverlayMode);
            return tabView;
        }
        public static T IsAddTabButtonVisible<T>(this T tabView, bool isAddTabButtonVisible) where T : TabView
        {
            tabView.SetValue (TabView.IsAddTabButtonVisibleProperty, isAddTabButtonVisible);
            return tabView;
        }
        public static T SelectedIndex<T>(this T tabView, int selectedIndex) where T : TabView
        {
            tabView.SetValue (TabView.SelectedIndexProperty, selectedIndex);
            return tabView;
        }
        public static T SelectedItem<T>(this T tabView, object selectedItem) where T : TabView
        {
            tabView.SetValue (TabView.SelectedItemProperty, selectedItem);
            return tabView;
        }
        public static T TabItemTemplate<T>(this T tabView, object selectedItem) where T : TabView
        {
            tabView.SetValue (TabView.TabItemTemplateProperty, selectedItem);
            return tabView;
        }
        public static T TabItemTemplateSelector<T>(this T tabView, object selectedItem) where T : TabView
        {
            tabView.SetValue (TabView.TabItemTemplateSelectorProperty, selectedItem);
            return tabView;
        }
        public static T TabItemsSource<T>(this T tabView, object tabItemsSource) where T : TabView
        {
            tabView.SetValue (TabView.TabItemsSourceProperty, tabItemsSource);
            return tabView;
        }

        public static T TabStripFooter<T>(this T tabView, object tabStripFooter) where T : TabView
        {
            tabView.SetValue (TabView.TabStripFooterProperty, tabStripFooter);
            return tabView;
        }
        public static T TabStripFooterTemplate<T>(this T tabView, DataTemplate tabStripFooterTemplate) where T : TabView
        {
            tabView.SetValue (TabView.TabStripFooterTemplateProperty, tabStripFooterTemplate);
            return tabView;
        }

        public static T TabStripHeader<T>(this T tabView, object tabStripHeader) where T : TabView
        {
            tabView.SetValue (TabView.TabStripHeaderProperty, tabStripHeader);
            return tabView;
        }
        public static T TabStripHeaderTemplate<T>(this T tabView, DataTemplate tabStripHeaderTemplate) where T : TabView
        {
            tabView.SetValue (TabView.TabStripHeaderTemplateProperty, tabStripHeaderTemplate);
            return tabView;
        }

        public static T TabWidthMode<T>(this T tabView, TabViewWidthMode tabWidthMode) where T : TabView
        {
            tabView.SetValue (TabView.TabWidthModeProperty, tabWidthMode);
            return tabView;
        }

        public static T OnAddTab<T>(this T tabView, TypedEventHandler<TabView, object> action ) where T : TabView
        {
            tabView.AddTabButtonClick += action;
            return tabView;
        }
        public static T OnTabClosed<T>(this T tabView, TypedEventHandler<TabView, TabViewTabCloseRequestedEventArgs> action) where T : TabView
        {
            tabView.TabCloseRequested += action;
            return tabView;
        }
    }
}
