namespace MarkupChain.WinUI3.Controls
{
    public static partial class TabViewItemExtensions
    {
        public static T Header<T>(this T tabViewItem, object header) where T : TabViewItem
        {
            tabViewItem.SetValue (TabViewItem.HeaderProperty, header);
            return tabViewItem;
        }
        public static T HeaderTemplate<T>(this T tabViewItem, DataTemplate headerTemplate) where T : TabViewItem
        {
            tabViewItem.SetValue (TabViewItem.HeaderTemplateProperty, headerTemplate);
            return tabViewItem;
        }
        public static T IconSource<T>(this T tabViewItem, IconSource iconSource) where T : TabViewItem
        {
            tabViewItem.SetValue (TabViewItem.IconSourceProperty, iconSource);
            return tabViewItem;
        }
        public static T IsClosable<T>(this T tabViewItem, bool isClosable) where T : TabViewItem
        {
            tabViewItem.SetValue (TabViewItem.IsClosableProperty, isClosable);
            return tabViewItem;
        }
    }
}
