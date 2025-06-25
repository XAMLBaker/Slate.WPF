namespace MarkupChain.WinUI3.Controls;

public static class PivotExtensions
{
    public static T HeaderFocusVisualPlacement<T>(this T pivot, PivotHeaderFocusVisualPlacement  placement) where T : Pivot
    {
        pivot.SetValue(Pivot.HeaderFocusVisualPlacementProperty, placement);
        return pivot;
    }
    
    public static T HeaderTemplate<T>(this T pivot, DataTemplate template) where T : Pivot
    {
        pivot.SetValue(Pivot.HeaderTemplateProperty, template);
        return pivot;
    }
    
    public static T IsHeaderItemsCarouselEnabled<T>(this T pivot, bool isEnabled) where T : Pivot
    {
        pivot.SetValue(Pivot.IsHeaderItemsCarouselEnabledProperty, isEnabled);
        return pivot;
    }
    
    public static T IsLocked<T>(this T pivot, bool isLocked) where T : Pivot
    {
        pivot.SetValue(Pivot.IsLockedProperty, isLocked);
        return pivot;
    }
    
    public static T LeftHeader<T>(this T pivot, object header) where T : Pivot
    {
        pivot.SetValue(Pivot.LeftHeaderProperty, header);
        return pivot;
    }
    
    public static T LeftHeaderTemplate<T>(this T pivot, DataTemplate template) where T : Pivot
    {
        pivot.SetValue(Pivot.LeftHeaderTemplateProperty, template);
        return pivot;
    }
    
    public static T RightHeader<T>(this T pivot, object header) where T : Pivot
    {
        pivot.SetValue(Pivot.RightHeaderProperty, header);
        return pivot;
    }
    
    public static T RightHeaderTemplate<T>(this T pivot, DataTemplate template) where T : Pivot
    {
        pivot.SetValue(Pivot.RightHeaderTemplateProperty, template);
        return pivot;
    }
    
    
    public static T SelectedIndex<T>(this T pivot, int index) where T : Pivot
    {
        pivot.SetValue(Pivot.SelectedIndexProperty, index);
        return pivot;
    }
    
    public static T SelectedItem<T>(this T pivot, object item) where T : Pivot
    {
        pivot.SetValue(Pivot.SelectedItemProperty, item);
        return pivot;
    }
    
    public static T SlideInAnimationGroup<T>(this T pivot, PivotSlideInAnimationGroup  group) where T : Pivot
    {
        pivot.SetValue(Pivot.SlideInAnimationGroupProperty, group);
        return pivot;
    }
    
    public static T Title<T>(this T pivot, object title) where T : Pivot
    {
        pivot.SetValue(Pivot.TitleProperty, title);
        return pivot;
    }
    
    public static T TitleTemplate<T>(this T pivot, DataTemplate template) where T : Pivot
    {
        pivot.SetValue(Pivot.TitleTemplateProperty, template);
        return pivot;
    }
}