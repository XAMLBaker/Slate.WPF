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

    public static class BrushTool
    {
        public static Brush Get(string hexString)
        {
            var _color = ColorTool.Get (hexString);
            var brush = new SolidColorBrush (_color);
            return brush;
        }
        public static Brush Get(Color color)
        {
            var brush = new SolidColorBrush (color);

            return brush;
        }
    }
}
