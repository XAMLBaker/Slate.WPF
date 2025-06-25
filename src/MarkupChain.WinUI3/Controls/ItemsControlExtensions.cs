using Microsoft.UI.Xaml.Media.Animation;

namespace MarkupChain.WinUI3.Controls;

public static class ItemsControlExtensions
{
    public static T DisplayMemberPath<T>(this T itemsControl, string path) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.DisplayMemberPathProperty, path);
        return itemsControl;
    }

    public static T GroupStyleSelector<T>(this T itemsControl, GroupStyleSelector selector) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.GroupStyleSelectorProperty, selector);
        return itemsControl;
    }
    
    public static T IsGrouping<T>(this T itemsControl, bool isGrouping) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.IsGroupingProperty, isGrouping);
        return itemsControl;
    }
    
    public static T ItemContainerStyle<T>(this T itemsControl, Style style) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.ItemContainerStyleProperty, style);
        return itemsControl;
    }
    
    public static T ItemContainerStyleSelector<T>(this T itemsControl, StyleSelector selector) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.ItemContainerStyleSelectorProperty, selector);
        return itemsControl;
    }
    
    public static T ItemContainerTransitions<T>(this T itemsControl, TransitionCollection transitions) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.ItemContainerTransitionsProperty, transitions);
        return itemsControl;
    }
    
    public static T ItemsPanel<T>(this T itemsControl, ItemsPanelTemplate itemsPanel) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.ItemsPanelProperty, itemsPanel);
        return itemsControl;
    }
    
    public static T ItemsSource<T>(this T itemsControl, object source) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.ItemsSourceProperty, source);
        return itemsControl;
    }
    
    public static T ItemTemplate<T>(this T itemsControl, DataTemplate template) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.ItemTemplateProperty, template);
        return itemsControl;
    }
    
    public static T ItemTemplateSelector<T>(this T itemsControl, DataTemplateSelector selector) where T : ItemsControl
    {
        itemsControl.SetValue(ItemsControl.ItemTemplateSelectorProperty, selector);
        return itemsControl;
    }
}