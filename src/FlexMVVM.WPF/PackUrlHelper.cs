using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
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
