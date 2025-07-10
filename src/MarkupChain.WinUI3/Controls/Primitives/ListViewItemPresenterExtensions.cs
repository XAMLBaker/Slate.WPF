namespace MarkupChain.WinUI3.Controls.Primitives;

public static class ListViewItemPresenterExtensions
{
    public static T CheckBoxBorderBrush<T>(this T listViewItemPresenter, Brush checkBoxBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxBorderBrushProperty,
            checkBoxBorderBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxBrush<T>(this T listViewItemPresenter, Brush checkBoxBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxBrushProperty,
            checkBoxBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxCornerRadius<T>(this T listViewItemPresenter, CornerRadius checkBoxCornerRadius)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxCornerRadiusProperty,
            checkBoxCornerRadius);
        return listViewItemPresenter;
    }

    public static T CheckBoxDisabledBrush<T>(this T listViewItemPresenter, Brush checkBoxDisabledBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxDisabledBrushProperty,
            checkBoxDisabledBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxDisabledBorderBrush<T>(this T listViewItemPresenter, Brush checkBoxDisabledBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxDisabledBorderBrushProperty,
            checkBoxDisabledBorderBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxPointerOverBorderBrush<T>(this T listViewItemPresenter,
        Brush checkBoxPointerOverBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxPointerOverBorderBrushProperty,
            checkBoxPointerOverBorderBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxPointerOverBrush<T>(this T listViewItemPresenter, Brush checkBoxPointerOverBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxPointerOverBrushProperty,
            checkBoxPointerOverBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxPressedBorderBrush<T>(this T listViewItemPresenter, Brush checkBoxPressedBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxPressedBorderBrushProperty,
            checkBoxPressedBorderBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxPressedBrush<T>(this T listViewItemPresenter, Brush checkBoxPressedBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxPressedBrushProperty,
            checkBoxPressedBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxSelectedBrush<T>(this T listViewItemPresenter, Brush checkBoxSelectedBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxSelectedBrushProperty,
            checkBoxSelectedBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxSelectedDisabledBrush<T>(this T listViewItemPresenter, Brush checkBoxSelectedDisabledBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxSelectedDisabledBrushProperty,
            checkBoxSelectedDisabledBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxSelectedPointerOverBrush<T>(this T listViewItemPresenter,
        Brush checkBoxSelectedPointerOverBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxSelectedPointerOverBrushProperty,
            checkBoxSelectedPointerOverBrush);
        return listViewItemPresenter;
    }

    public static T CheckBoxSelectedPressedBrush<T>(this T listViewItemPresenter, Brush checkBoxSelectedPressedBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBoxSelectedPressedBrushProperty,
            checkBoxSelectedPressedBrush);
        return listViewItemPresenter;
    }

    public static T CheckBrush<T>(this T listViewItemPresenter, Brush checkBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckBrushProperty, checkBrush);
        return listViewItemPresenter;
    }

    public static T CheckDisabledBrush<T>(this T listViewItemPresenter, Brush checkDisabledBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckDisabledBrushProperty, checkDisabledBrush);
        return listViewItemPresenter;
    }

    public static T CheckHintBrush<T>(this T listViewItemPresenter, Brush checkHintBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckHintBrushProperty, checkHintBrush);
        return listViewItemPresenter;
    }

    public static T CheckMode<T>(this T listViewItemPresenter, ListViewItemPresenterCheckMode checkMode)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckModeProperty, checkMode);
        return listViewItemPresenter;
    }

    public static T CheckPressedBrush<T>(this T listViewItemPresenter, Brush checkPressedBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckPressedBrushProperty, checkPressedBrush);
        return listViewItemPresenter;
    }

    public static T CheckSelectingBrush<T>(this T listViewItemPresenter, Brush checkSelectingBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.CheckSelectingBrushProperty, checkSelectingBrush);
        return listViewItemPresenter;
    }

    public static T ContentMargin<T>(this T listViewItemPresenter, Thickness contentMargin)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.ContentMarginProperty, contentMargin);
        return listViewItemPresenter;
    }

    public static T DisabledOpacity<T>(this T listViewItemPresenter, double disabledOpacity)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.DisabledOpacityProperty, disabledOpacity);
        return listViewItemPresenter;
    }

    public static T DragBackground<T>(this T listViewItemPresenter, Brush dragBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.DragBackgroundProperty, dragBackground);
        return listViewItemPresenter;
    }

    public static T DragForeground<T>(this T listViewItemPresenter, Brush dragForeground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.DragForegroundProperty, dragForeground);
        return listViewItemPresenter;
    }

    public static T DragOpacity<T>(this T listViewItemPresenter, double dragOpacity)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.DragOpacityProperty, dragOpacity);
        return listViewItemPresenter;
    }

    public static T FocusBorderBrush<T>(this T listViewItemPresenter, Brush focusBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.FocusBorderBrushProperty, focusBorderBrush);
        return listViewItemPresenter;
    }

    public static T FocusSecondaryBorderBrush<T>(this T listViewItemPresenter, Brush focusSecondaryBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.FocusSecondaryBorderBrushProperty,
            focusSecondaryBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T PlaceholderBackground<T>(this T listViewItemPresenter, Brush placeholderBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.PlaceholderBackgroundProperty, placeholderBackground);
        return listViewItemPresenter;
    }
    
    public static T PointerOverBackground<T>(this T listViewItemPresenter, Brush pointerOverBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.PointerOverBackgroundProperty, pointerOverBackground);
        return listViewItemPresenter;
    }

    public static T PointerOverBackgroundMargin<T>(this T listViewItemPresenter, Thickness pointerOverBackgroundMargin)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.PointerOverBackgroundMarginProperty,
            pointerOverBackgroundMargin);
        return listViewItemPresenter;
    }
    
    public static T PointerOverBorderBrush<T>(this T listViewItemPresenter, Brush pointerOverBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.PointerOverBorderBrushProperty, pointerOverBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T PointerOverForeground<T>(this T listViewItemPresenter, Brush pointerOverForeground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.PointerOverForegroundProperty, pointerOverForeground);
        return listViewItemPresenter;
    }
    
    public static T PressedBackground<T>(this T listViewItemPresenter, Brush pressedBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.PressedBackgroundProperty, pressedBackground);
        return listViewItemPresenter;
    }
    
    public static T ReorderHintOffset<T>(this T listViewItemPresenter, double reorderHintOffset)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.ReorderHintOffsetProperty, reorderHintOffset);
        return listViewItemPresenter;
    }
    
    public static T RevealBackground<T>(this T listViewItemPresenter, Brush revealBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.RevealBackgroundProperty, revealBackground);
        return listViewItemPresenter;
    }
    
    public static T RevealBackgroundShowsAboveContent<T>(this T listViewItemPresenter, bool revealBackgroundShowsAboveContent)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.RevealBackgroundShowsAboveContentProperty,
            revealBackgroundShowsAboveContent);
        return listViewItemPresenter;
    }
    
    public static T RevealBorderBrush<T>(this T listViewItemPresenter, Brush revealBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.RevealBorderBrushProperty, revealBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T RevealBorderThickness<T>(this T listViewItemPresenter, Thickness revealBorderThickness)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.RevealBorderThicknessProperty, revealBorderThickness);
        return listViewItemPresenter;
    }
    
    public static T SelectedBackground<T>(this T listViewItemPresenter, Brush selectedBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedBackgroundProperty, selectedBackground);
        return listViewItemPresenter;
    }
    
    public static T SelectedBorderBrush<T>(this T listViewItemPresenter, Brush selectedBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedBorderBrushProperty, selectedBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectedBorderThickness<T>(this T listViewItemPresenter, Thickness selectedBorderThickness)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedBorderThicknessProperty, selectedBorderThickness);
        return listViewItemPresenter;
    }
    
    public static T SelectedForeground<T>(this T listViewItemPresenter, Brush selectedForeground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedForegroundProperty, selectedForeground);
        return listViewItemPresenter;
    }
    
    public static T SelectedDisabledBackground<T>(this T listViewItemPresenter, Brush selectedDisabledBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedDisabledBackgroundProperty, selectedDisabledBackground);
        return listViewItemPresenter;
    }
    
    public static T SelectedDisabledBorderBrush<T>(this T listViewItemPresenter, Brush selectedDisabledBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedDisabledBorderBrushProperty, selectedDisabledBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectedInnerBorderBrush<T>(this T listViewItemPresenter, Brush selectedInnerBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedInnerBorderBrushProperty, selectedInnerBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T  SelectedPointerOverBackground<T>(this T listViewItemPresenter, Brush selectedPointerOverBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedPointerOverBackgroundProperty,
            selectedPointerOverBackground);
        return listViewItemPresenter;
    }
    
    public static T SelectedPointerOverBorderBrush<T>(this T listViewItemPresenter, Brush selectedPointerOverBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedPointerOverBorderBrushProperty,
            selectedPointerOverBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectedPressedBackground<T>(this T listViewItemPresenter, Brush selectedPressedBackground)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedPressedBackgroundProperty,
            selectedPressedBackground);
        return listViewItemPresenter;
    }
    
    public static T SelectedPressedBorderBrush<T>(this T listViewItemPresenter, Brush selectedPressedBorderBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectedPressedBorderBrushProperty,
            selectedPressedBorderBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectionCheckMarkVisualEnabled<T>(this T listViewItemPresenter, bool selectionCheckMarkVisualEnabled)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionCheckMarkVisualEnabledProperty,
            selectionCheckMarkVisualEnabled);
        return listViewItemPresenter;
    }
    
    public static T SelectionIndicatorBrush<T>(this T listViewItemPresenter, Brush selectionIndicatorBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionIndicatorBrushProperty, selectionIndicatorBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectionIndicatorCornerRadius<T>(this T listViewItemPresenter, CornerRadius selectionIndicatorCornerRadius)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionIndicatorCornerRadiusProperty,
            selectionIndicatorCornerRadius);
        return listViewItemPresenter;
    }
    
    public static T SelectionIndicatorDisabledBrush<T>(this T listViewItemPresenter, Brush selectionIndicatorDisabledBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionIndicatorDisabledBrushProperty,
            selectionIndicatorDisabledBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectionIndicatorMode<T>(this T listViewItemPresenter, ListViewItemPresenterSelectionIndicatorMode selectionIndicatorMode)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionIndicatorModeProperty, selectionIndicatorMode);
        return listViewItemPresenter;
    }
    
    public static T SelectionIndicatorPointerOverBrush<T>(this T listViewItemPresenter, Brush selectionIndicatorPointerOverBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionIndicatorPointerOverBrushProperty,
            selectionIndicatorPointerOverBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectionIndicatorPressedBrush<T>(this T listViewItemPresenter, Brush selectionIndicatorPressedBrush)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionIndicatorPressedBrushProperty,
            selectionIndicatorPressedBrush);
        return listViewItemPresenter;
    }
    
    public static T SelectionIndicatorVisualEnabled<T>(this T listViewItemPresenter, bool selectionIndicatorVisualEnabled)
        where T : ListViewItemPresenter
    {
        listViewItemPresenter.SetValue(ListViewItemPresenter.SelectionIndicatorVisualEnabledProperty,
            selectionIndicatorVisualEnabled);
        return listViewItemPresenter;
    }
    
    
}
    
   