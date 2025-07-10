namespace MarkupChain.WinUI3.Controls;

public static class ColumnDefinitionExtensions
{
    public static ColumnDefinition MaxWidth(this ColumnDefinition columnDefinition, double maxWidth)
    {
        columnDefinition.SetValue(ColumnDefinition.MaxWidthProperty, maxWidth);
        return columnDefinition;
    }
    
    public static ColumnDefinition MinWidth(this ColumnDefinition columnDefinition, double minWidth)
    {
        columnDefinition.SetValue(ColumnDefinition.MinWidthProperty, minWidth);
        return columnDefinition;
    }
    
    public static ColumnDefinition Width(this ColumnDefinition columnDefinition, GridLength width)
    {
        columnDefinition.SetValue(ColumnDefinition.WidthProperty, width);
        return columnDefinition;
    }
}