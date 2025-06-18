using System.Windows;

namespace Slate.WPF
{
    public static class PackUrlHelper
    {
        public static string Load(FrameworkElement element, string path)
        {
            var name = element.GetType().Assembly.GetName ();

            return $"pack://application:,,,/{name};component/{path}";
        }
    }
}
