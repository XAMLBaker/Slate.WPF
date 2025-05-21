using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace FlexMVVM.WPF.Markup
{
    public static class ColorTool
    {
        public static Color Get(string hexString)
        {
            return (Color)ColorConverter.ConvertFromString (hexString);
        }
    }
}
