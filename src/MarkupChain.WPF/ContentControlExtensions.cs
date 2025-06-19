namespace MarkupChain.WPF
{
    public static class ContentControlExtensions
    {
        public static T Content<T>(this T cc, object obj) where T : ContentControl
        {
            cc.SetValue (ContentControl.ContentProperty, obj);
            return cc;
        }
    }
}
