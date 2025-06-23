namespace MarkupChain.WPF
{
    public static partial class ImageExtensions
    {
        public static T Source<T>(this T image, string Source) where T : Image
        {
            image.SetValue(Image.SourceProperty, SetImageSource (Source));
            return image;
        }

        public static T Stretch<T>(this T image, Stretch stretch) where T : Image
        {
            image.SetValue (Image.StretchProperty, stretch);
            return image;
        }

        public static T StretchDirection<T>(this T image, StretchDirection stretchDirection) where T : Image
        {
            image.SetValue (Image.StretchDirectionProperty, stretchDirection);
            return image;
        }
    }
}
