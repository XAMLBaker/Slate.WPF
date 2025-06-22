using System.Windows.Data;

namespace Slate.WPF.Markup
{
    public static partial class BindingExtensions
    {
        public static T Background<T>(this T bdr, IState state) where T : Border
        {
            return bdr.Binding (Border.BackgroundProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T Padding<T>(this T bdr, IState state) where T : Border
        {
            return bdr.Binding (Border.PaddingProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T CornerRadius<T>(this T bdr, IState state) where T : Border
        {
            return bdr.Binding (Border.CornerRadiusProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T BorderBrush<T>(this T bdr, IState state) where T : Border
        {
            return bdr.Binding (Border.BorderBrushProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T BorderThickness<T>(this T bdr, IState state) where T : Border
        {
            return bdr.Binding (Border.BorderThicknessProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
    }
}
