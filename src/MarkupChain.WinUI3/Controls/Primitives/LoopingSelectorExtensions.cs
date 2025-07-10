namespace MarkupChain.WinUI3.Controls.Primitives;

public static class LoopingSelectorExtensions
{
    public static LoopingSelector ItemHeight(this LoopingSelector loopingSelector, int itemHeight)
    {
        loopingSelector.SetValue(LoopingSelector.ItemHeightProperty, itemHeight);
        return loopingSelector;
    }
    
    public static LoopingSelector ItemTemplate(this LoopingSelector loopingSelector, DataTemplate itemTemplate)
    {
        loopingSelector.SetValue(LoopingSelector.ItemTemplateProperty, itemTemplate);
        return loopingSelector;
    }
    
    public static LoopingSelector Items(this LoopingSelector loopingSelector, IList<object> items)
    {
        loopingSelector.SetValue(LoopingSelector.ItemsProperty, items);
        return loopingSelector;
    }
}