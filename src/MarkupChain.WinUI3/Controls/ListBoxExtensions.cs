namespace MarkupChain.WinUI3.Controls;

public static class ListBoxExtensions
{
    public static T SelectionMode<T>(this T listBox, SelectionMode selectionMode) where T : ListBox
    {
        listBox.SetValue(ListBox.SelectionModeProperty, selectionMode);
        return listBox;
    }
    
    public static T SingleSelectionFollowsFocus<T>(this T listBox, bool singleSelectionFollowsFocus) where T : ListBox
    {
        listBox.SetValue(ListBox.SingleSelectionFollowsFocusProperty, singleSelectionFollowsFocus);
        return listBox;
    }
}