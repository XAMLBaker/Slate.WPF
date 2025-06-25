namespace MarkupChain.WinUI3.Controls;

public static class AutoSuggestBoxExtensions
{
    public static AutoSuggestBox AutoMaximizeSuggestionArea(this AutoSuggestBox autoSuggestBox, bool autoMaximize) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.AutoMaximizeSuggestionAreaProperty, autoMaximize);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox Description(this AutoSuggestBox autoSuggestBox, object description) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.DescriptionProperty, description);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox Header (this AutoSuggestBox autoSuggestBox, object header) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.HeaderProperty, header);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox IsSuggestionListOpen(this AutoSuggestBox autoSuggestBox, bool isSuggestionListOpen) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.IsSuggestionListOpenProperty, isSuggestionListOpen);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox LightDismissOverlayMode(this AutoSuggestBox autoSuggestBox, LightDismissOverlayMode mode) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.LightDismissOverlayModeProperty, mode);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox MaxSuggestionListHeight(this AutoSuggestBox autoSuggestBox, double maxHeight) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.MaxSuggestionListHeightProperty, maxHeight);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox PlaceholderText(this AutoSuggestBox autoSuggestBox, string placeholderText) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.PlaceholderTextProperty, placeholderText);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox QueryIcon(this AutoSuggestBox autoSuggestBox, IconElement queryIcon) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.QueryIconProperty, queryIcon);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox Text(this AutoSuggestBox autoSuggestBox, string text) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.TextProperty, text);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox TextBoxStyle(this AutoSuggestBox autoSuggestBox, Style textBoxStyle) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.TextBoxStyleProperty, textBoxStyle);
        return autoSuggestBox;
    }

    public static AutoSuggestBox TextMemberPath(this AutoSuggestBox autoSuggestBox, string textMemberPath)
    {
        autoSuggestBox.SetValue(AutoSuggestBox.TextMemberPathProperty, textMemberPath);
        return autoSuggestBox;
    }
    
    public static AutoSuggestBox UpdateTextOnSelect(this AutoSuggestBox autoSuggestBox, bool updateTextOnSelect) 
    {
        autoSuggestBox.SetValue(AutoSuggestBox.UpdateTextOnSelectProperty, updateTextOnSelect);
        return autoSuggestBox;
    }
}