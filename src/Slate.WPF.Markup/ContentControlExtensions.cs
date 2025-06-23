using System.Windows.Data;


namespace Slate.WPF.Markup
{
    public static partial class ContentControlExtensions
    {
        public static T Content<T>(this T cc, IState state) where T : ContentControl
        {
            return cc.Binding (ContentControl.ContentProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
    }
}
