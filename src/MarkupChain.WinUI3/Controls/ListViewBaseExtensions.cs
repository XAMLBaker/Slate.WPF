using Microsoft.UI.Xaml.Media.Animation;

namespace MarkupChain.WinUI3.Controls;

public static class ListViewBaseExtensions
{
    public static T CanDragItems<T>(this T control, bool canDrag) where T : ListViewBase
    {
        control.SetValue(ListViewBase.CanDragItemsProperty, canDrag);
        return control;
    }

    public static T CanReorderItems<T>(this T control, bool canReorder) where T : ListViewBase
    {
        control.SetValue(ListViewBase.CanReorderItemsProperty, canReorder);
        return control;
    }

    public static T DataFetchSize<T>(this T control, double size) where T : ListViewBase
    {
        control.SetValue(ListViewBase.DataFetchSizeProperty, size);
        return control;
    }

    public static T Footer<T>(this T control, object footer) where T : ListViewBase
    {
        control.SetValue(ListViewBase.FooterProperty, footer);
        return control;
    }

    public static T FooterTemplate<T>(this T control, DataTemplate template) where T : ListViewBase
    {
        control.SetValue(ListViewBase.FooterTemplateProperty, template);
        return control;
    }

    public static T FooterTransitions<T>(this T control, TransitionCollection transitions) where T : ListViewBase
    {
        control.SetValue(ListViewBase.FooterTransitionsProperty, transitions);
        return control;
    }

    public static T Header<T>(this T control, object header) where T : ListViewBase
    {
        control.SetValue(ListViewBase.HeaderProperty, header);
        return control;
    }

    public static T HeaderTemplate<T>(this T control, DataTemplate template) where T : ListViewBase
    {
        control.SetValue(ListViewBase.HeaderTemplateProperty, template);
        return control;
    }

    public static T HeaderTransitions<T>(this T control, TransitionCollection transitions) where T : ListViewBase
    {
        control.SetValue(ListViewBase.HeaderTransitionsProperty, transitions);
        return control;
    }

    public static T IncrementalLoadingThreshold<T>(this T control, double threshold) where T : ListViewBase
    {
        control.SetValue(ListViewBase.IncrementalLoadingThresholdProperty, threshold);
        return control;
    }

    public static T IncrementalLoadingTrigger<T>(this T control, IncrementalLoadingTrigger trigger)
        where T : ListViewBase
    {
        control.SetValue(ListViewBase.IncrementalLoadingTriggerProperty, trigger);
        return control;
    }

    public static T IsActiveView<T>(this T control, bool isActive) where T : ListViewBase
    {
        control.SetValue(ListViewBase.IsActiveViewProperty, isActive);
        return control;
    }

    public static T IsItemClickEnabled<T>(this T control, bool isEnabled) where T : ListViewBase
    {
        control.SetValue(ListViewBase.IsItemClickEnabledProperty, isEnabled);
        return control;
    }

    public static T IsMultiSelectCheckBoxEnabled<T>(this T control, bool isEnabled) where T : ListViewBase
    {
        control.SetValue(ListViewBase.IsMultiSelectCheckBoxEnabledProperty, isEnabled);
        return control;
    }

    public static T IsSwipeEnabled<T>(this T control, bool isEnabled) where T : ListViewBase
    {
        control.SetValue(ListViewBase.IsSwipeEnabledProperty, isEnabled);
        return control;
    }

    public static T IsZoomedInView<T>(this T control, bool isZoomedIn) where T : ListViewBase
    {
        control.SetValue(ListViewBase.IsZoomedInViewProperty, isZoomedIn);
        return control;
    }

    public static T ReorderMode<T>(this T control, ListViewReorderMode mode) where T : ListViewBase
    {
        control.SetValue(ListViewBase.ReorderModeProperty, mode);
        return control;
    }

    public static T SelectionMode<T>(this T control, ListViewSelectionMode mode) where T : ListViewBase
    {
        control.SetValue(ListViewBase.SelectionModeProperty, mode);
        return control;
    }
    
    public static T SemanticZoomOwner<T>(this T control, SemanticZoom semanticZoom) where T : ListViewBase
    {
        control.SetValue(ListViewBase.SemanticZoomOwnerProperty, semanticZoom);
        return control;
    }
    
    public static T ShowsScrollingPlaceholders<T>(this T control, bool showsPlaceholders) where T : ListViewBase
    {
        control.SetValue(ListViewBase.ShowsScrollingPlaceholdersProperty, showsPlaceholders);
        return control;
    }
    
    public static T SingleSelectionFollowsFocus<T>(this T control, bool followsFocus) where T : ListViewBase
    {
        control.SetValue(ListViewBase.SingleSelectionFollowsFocusProperty, followsFocus);
        return control;
    }
}