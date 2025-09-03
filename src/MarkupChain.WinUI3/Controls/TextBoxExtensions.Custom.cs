using Windows.UI;

namespace MarkupChain.WinUI3.Controls
{
    public static partial class TextBoxExtensions
    {
        public static T BorderBrush<T>(this T textBox, string color) where T : TextBox
        {
            textBox.SetValue (TextBox.BorderBrushProperty, BrushTool.Get (color));

            return textBox;
        }
        public static T BorderBrush<T>(this T textBox, Color color) where T : TextBox
        {
            textBox.SetValue (TextBox.BorderBrushProperty, BrushTool.Get (color));

            return textBox;
        }

        public static T BorderThickness<T>(this T textBox, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : TextBox
        {
            textBox.SetValue (TextBox.BorderThicknessProperty, new Thickness (left, top, right, bottom));
            return textBox;
        }
    }
}
