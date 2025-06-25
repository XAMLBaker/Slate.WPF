namespace MarkupChain.WinUI3.Controls;

public static class ComboboxExtensions
{
    public static T Description<T>(this T comboBox, object description) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.DescriptionProperty, description);
        return comboBox;
    }

    public static T Header<T>(this T comboBox, object header) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.HeaderProperty, header);
        return comboBox;
    }

    public static T HeaderTemplate<T>(this T comboBox, DataTemplate template) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.HeaderTemplateProperty, template);
        return comboBox;
    }

    public static T IsEditable<T>(this T comboBox, bool isEditable) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.IsEditableProperty, isEditable);
        return comboBox;
    }

    public static T IsDropDownOpen<T>(this T comboBox, bool isDropDownOpen) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.IsDropDownOpenProperty, isDropDownOpen);
        return comboBox;
    }

    public static T IsTextSearchEnabled<T>(this T comboBox, bool isTextSearchEnabled) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.IsTextSearchEnabledProperty, isTextSearchEnabled);
        return comboBox;
    }

    public static T LightDismissOverlayMode<T>(this T comboBox, LightDismissOverlayMode mode) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.LightDismissOverlayModeProperty, mode);
        return comboBox;
    }

    public static T MaxDropDownHeight<T>(this T comboBox, double height) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.MaxDropDownHeightProperty, height);
        return comboBox;
    }

    public static T PlaceholderForeground<T>(this T comboBox, Brush brush) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.PlaceholderForegroundProperty, brush);
        return comboBox;
    }

    public static T PlaceholderText<T>(this T comboBox, string text) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.PlaceholderTextProperty, text);
        return comboBox;
    }

    public static T SelectionChangedTrigger<T>(this T comboBox, ComboBoxSelectionChangedTrigger trigger)
        where T : ComboBox
    {
        comboBox.SetValue(ComboBox.SelectionChangedTriggerProperty, trigger);
        return comboBox;
    }
    
    public static T Text<T>(this T comboBox, string text) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.TextProperty, text);
        return comboBox;
    }
    
    public static T TextBoxStyle<T>(this T comboBox, Style style) where T : ComboBox
    {
        comboBox.SetValue(ComboBox.TextBoxStyleProperty, style);
        return comboBox;
    }
}