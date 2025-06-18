using System.Windows.Media;

namespace Slate.WPF
{
    public static class PathExtensions
    {
        // 봉인 클래스라서 확장이안된다네 ..ㅠ
        //public static T Data<T>(this T path, string pathData) where T : Path
        //{
        //    Geometry geometry = Geometry.Parse (pathData);
        //    path.Data = geometry;
        //    return path;
        //}

        public static Geometry Data(string pathData)
        {
            return Geometry.Parse (pathData);
        }
    }
}
