using System.Windows.Media.Imaging;

namespace MarkupChain.WPF
{
    public static partial class ImageExtensions
    {
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
