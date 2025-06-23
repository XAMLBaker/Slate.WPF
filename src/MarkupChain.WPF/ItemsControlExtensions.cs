using System.Collections;
using System.Windows.Data;

namespace Slate.WPF.Markup
{
    public static class ItemsControlExtensions
    {
        public static T AlternationCount<T>(this T Ic, int alternationCount) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.AlternationCountProperty, alternationCount);
            return Ic;
        }

        public static T ItemTemplateSelector<T>(this T Ic, DataTemplateSelector itemTemplateSelector) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemTemplateSelectorProperty, itemTemplateSelector);
            return Ic;
        }

        public static T ItemTemplate<T>(this T Ic, DataTemplate itemTemplate) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemTemplateProperty, itemTemplate);
            return Ic;
        }

        public static T ItemStringFormat<T>(this T Ic, string itemStringFormat) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemStringFormatProperty, itemStringFormat);
            return Ic;
        }

        public static T ItemsPanel<T>(this T Ic, ItemsPanelTemplate itemsPanel) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemsPanelProperty, itemsPanel);
            return Ic;
        }

        public static T ItemContainerStyleSelector<T>(this T Ic, StyleSelector itemContainerStyleSelector) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemContainerStyleSelectorProperty, itemContainerStyleSelector);
            return Ic;
        }

        public static T ItemContainerStyle<T>(this T Ic, StyleSelector itemContainerStyle) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemContainerStyleProperty, itemContainerStyle);
            return Ic;
        }

        public static T ItemBindingGroup<T>(this T Ic, BindingGroup itemBindingGroup) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemBindingGroupProperty, itemBindingGroup);
            return Ic;
        }

        public static T ItemsSource<T>(this T Ic, IEnumerable itemSource) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.ItemsSourceProperty, itemSource);
            return Ic;
        }

        public static T IsTextSearchCaseSensitive<T>(this T Ic, ItemsPanelTemplate itemsPanel) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.IsTextSearchCaseSensitiveProperty, itemsPanel);
            return Ic;
        }
        public static T IsGrouping<T>(this T Ic, bool isGrouping) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.IsGroupingProperty, isGrouping);
            return Ic;
        }
        public static T HasItems<T>(this T Ic, bool hasItems) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.HasItemsProperty, hasItems);
            return Ic;
        }

        public static T GroupStyleSelector<T>(this T Ic, GroupStyleSelector groupStyleSelector) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.GroupStyleSelectorProperty, groupStyleSelector);
            return Ic;
        }

        public static T DisplayMemberPath<T>(this T Ic, string displayMemberPath) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.DisplayMemberPathProperty, displayMemberPath);
            return Ic;
        }

        public static T IsTextSearchEnabled<T>(this T Ic, bool isTextSearchEnabled) where T : ItemsControl
        {
            Ic.SetValue (ItemsControl.IsTextSearchEnabledProperty, isTextSearchEnabled);
            return Ic;
        }
    }
}
