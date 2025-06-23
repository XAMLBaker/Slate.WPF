using System.Windows.Data;


namespace Slate.WPF.Markup
{
    public static partial class ImageExtensions
    {
        public static T Source<T>(this T image, IState state) where T : Image
        {
            return image.Binding (Image.SourceProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T Stretch<T>(this T image, IState state) where T : Image
        {
            return image.Binding (Image.StretchProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T StretchDirection<T>(this T image, IState state) where T : Image
        {
            return image.Binding (Image.StretchDirectionProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
    }
}
