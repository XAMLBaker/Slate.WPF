using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF.Markup
{
    public static partial class BorderExtentions
    {
        public static T Background<T>(this T bdr, Brush color) where T : Border
        {
            bdr.SetValue (Border.BackgroundProperty, color);
            return bdr;
        }

        public static T Padding<T>(this T bdr, Thickness padding) where T : Border
        {
            bdr.SetValue(Border.PaddingProperty, padding);
            return bdr;
        }
        public static T CornerRadius<T>(this T bdr, CornerRadius cornerRadius) where T : Border
        {
            bdr.SetValue (Border.CornerRadiusProperty, cornerRadius);
            return bdr;
        }

        public static T BorderBrush<T>(this T bdr, Brush color) where T : Border
        {
            bdr.SetValue(Border.BorderBrushProperty, color);
            return bdr;
        }

        public static T BorderThickness<T>(this T bdr, Thickness padding) where T : Border
        {
            bdr.SetValue (Border.BorderThicknessProperty, padding);
            return bdr;
        }
    }
}
