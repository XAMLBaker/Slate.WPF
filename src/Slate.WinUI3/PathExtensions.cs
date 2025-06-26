using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;

namespace Slate.WinUI3
{
    public static class PathExtensions
    {
        public static Geometry Data(string pathData)
        {
            // XAML 문자열 생성
            string xaml = $"<PathGeometry xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" Figures=\"{pathData}\" />";

            // XamlReader로 파싱
            return (Geometry)XamlReader.Load (xaml);
        }
    }
}
