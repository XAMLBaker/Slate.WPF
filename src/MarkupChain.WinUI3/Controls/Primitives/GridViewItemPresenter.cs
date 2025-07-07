namespace MarkupChain.WinUI3.Controls.Primitives;

public static class GridViewItemPresenter
{
    public static T CheckBrush<T>(this T gridViewItemPresenter, Brush checkBrush)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.CheckBrushProperty,
            checkBrush);
        return gridViewItemPresenter;
    }

    public static T CheckHintBrush<T>(this T gridViewItemPresenter, Brush checkHintBrush)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.CheckHintBrushProperty, checkHintBrush);
        return gridViewItemPresenter;
    }

    public static T CheckSelectingBrush<T>(this T gridViewItemPresenter, Brush checkSelectingBrush)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.CheckSelectingBrushProperty,
            checkSelectingBrush);
        return gridViewItemPresenter;
    }

    public static T ContentMargin<T>(this T gridViewItemPresenter, Thickness contentMargin)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.ContentMarginProperty, contentMargin);
        return gridViewItemPresenter;
    }

    public static T DisabledOpacity<T>(this T gridViewItemPresenter, double disabledOpacity)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.DisabledOpacityProperty, disabledOpacity);
        return gridViewItemPresenter;
    }

    public static T DragBackground<T>(this T gridViewItemPresenter, Brush dragBackground)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.DragBackgroundProperty, dragBackground);
        return gridViewItemPresenter;
    }

    public static T DragForeground<T>(this T gridViewItemPresenter, Brush dragForeground)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.DragForegroundProperty, dragForeground);
        return gridViewItemPresenter;
    }

    public static T DragOpacity<T>(this T gridViewItemPresenter, double dragOpacity)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.DragOpacityProperty,
            dragOpacity);
        return gridViewItemPresenter;
    }

    public static T FocusBorderBrush<T>(this T gridViewItemPresenter, Brush focusBorderBrush)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.FocusBorderBrushProperty, focusBorderBrush);
        return gridViewItemPresenter;
    }

    public static T PlaceholderBackground<T>(this T gridViewItemPresenter, Brush placeholderBackground)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.PlaceholderBackgroundProperty,
            placeholderBackground);
        return gridViewItemPresenter;
    }

    public static T PointerOverBackground<T>(this T gridViewItemPresenter, Brush pointerOverBackground)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.PointerOverBackgroundProperty,
            pointerOverBackground);
        return gridViewItemPresenter;
    }

    public static T PointerOverBackgroundMargin<T>(this T gridViewItemPresenter, Thickness pointerOverBackgroundMargin)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.PointerOverBackgroundMarginProperty,
            pointerOverBackgroundMargin);
        return gridViewItemPresenter;
    }

    public static T ReorderHintOffset<T>(this T gridViewItemPresenter, double reorderHintOffset)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.ReorderHintOffsetProperty, reorderHintOffset);
        return gridViewItemPresenter;
    }

    public static T SelectedBackground<T>(this T gridViewItemPresenter, Brush selectedBackground)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectedBackgroundProperty, selectedBackground);
        return gridViewItemPresenter;
    }

    public static T SelectedBorderThickness<T>(this T gridViewItemPresenter, Thickness selectedBorderThickness)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectedBorderThicknessProperty,
            selectedBorderThickness);
        return gridViewItemPresenter;
    }

    public static T SelectedForeground<T>(this T gridViewItemPresenter, Brush selectedForeground)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectedForegroundProperty, selectedForeground);
        return gridViewItemPresenter;
    }

    public static T SelectedPointerOverBackground<T>(this T gridViewItemPresenter, Brush selectedPointerOverBackground)
        where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectedPointerOverBackgroundProperty,
            selectedPointerOverBackground);
        return gridViewItemPresenter;
    }

    public static T SelectedPointerOverBorderBrush<T>(this T gridViewItemPresenter,
        Brush selectedPointerOverBorderBrush) where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectedPointerOverBorderBrushProperty,
            selectedPointerOverBorderBrush);
        return gridViewItemPresenter;
    }

    public static T SelectionCheckMarkVisualEnabled<T>(this T gridViewItemPresenter,
        bool selectionCheckMarkVisualEnabled) where T : Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter
    {
        gridViewItemPresenter.SetValue(
            Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.SelectionCheckMarkVisualEnabledProperty,
            selectionCheckMarkVisualEnabled);
        return gridViewItemPresenter;
    }
}