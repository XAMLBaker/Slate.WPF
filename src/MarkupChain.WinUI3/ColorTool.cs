using Windows.UI;
namespace MarkupChain.WinUI3
{
    public static class ColorTool
    {
        public static Color Get(string hexString)
        {
            // #AARRGGBB 또는 #RRGGBB 지원
            var temp = hexString.Replace ("#", "");

            byte a = 255, r = 0, g = 0, b = 0;

            if (temp.Length == 8)
            {
                a = byte.Parse (temp.Substring (0, 2), System.Globalization.NumberStyles.HexNumber);
                r = byte.Parse (temp.Substring (2, 2), System.Globalization.NumberStyles.HexNumber);
                g = byte.Parse (temp.Substring (4, 2), System.Globalization.NumberStyles.HexNumber);
                b = byte.Parse (temp.Substring (6, 2), System.Globalization.NumberStyles.HexNumber);
            }
            else if (temp.Length == 6)
            {
                r = byte.Parse (temp.Substring (0, 2), System.Globalization.NumberStyles.HexNumber);
                g = byte.Parse (temp.Substring (2, 2), System.Globalization.NumberStyles.HexNumber);
                b = byte.Parse (temp.Substring (4, 2), System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                throw new ArgumentException ("Hex string must be in format #RRGGBB or #AARRGGBB.");
            }

            return Color.FromArgb (a, r, g, b);
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
