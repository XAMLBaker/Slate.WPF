using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FlexMVVM.WPF.Markup
{
    public static class ImageExtensions
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

        private static BitmapImage SetImageSource(string packUri)
        {
            try
            {
                Uri imageUri;
                imageUri = new Uri (packUri, UriKind.RelativeOrAbsolute);

                // BitmapImage로 설정
                var bitmap = new BitmapImage ();
                bitmap.BeginInit ();
                bitmap.UriSource = imageUri;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit ();
                bitmap.Freeze ();
                return bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"이미지를 로드하는 중 오류가 발생했습니다: {ex.Message}");
            }

            return null;
        }
    }
}
