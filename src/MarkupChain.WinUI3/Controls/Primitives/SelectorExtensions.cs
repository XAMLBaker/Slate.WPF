namespace MarkupChain.WinUI3.Controls.Primitives;

public static class SelectorExtensions
{
    public static T IsSynchronizedWithCurrentItem<T>(this T selector, bool isSynchronized) where T : Selector
    {
        selector.SetValue(Selector.IsSynchronizedWithCurrentItemProperty, isSynchronized);
        return selector;
    }
    
    public static T SelectedIndex<T>(this T selector, int index) where T : Selector
    {
        selector.SetValue(Selector.SelectedIndexProperty, index);
        return selector;
    }
    
    public static T SelectedItem<T>(this T selector, object item) where T : Selector
    {
        selector.SetValue(Selector.SelectedItemProperty, item);
        return selector;
    }
    
    public static T SelectedValue<T>(this T selector, object value) where T : Selector
    {
        selector.SetValue(Selector.SelectedValueProperty, value);
        return selector;
    }
    
    public static T SelectedValuePath<T>(this T selector, string path) where T : Selector
    {
        selector.SetValue(Selector.SelectedValuePathProperty, path);
        return selector;
    }
}