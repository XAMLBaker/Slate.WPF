namespace MarkupChain.WinUI3.Controls.Primitives;

public static class ColorPickerSliderExtensions
{
    public static T ColorChannel<T>(this T colorPickerSlider, ColorPickerHsvChannel colorChannel)
        where T : ColorPickerSlider
    {
        colorPickerSlider.SetValue(ColorPickerSlider.ColorChannelProperty, colorChannel);
        return colorPickerSlider;
    }
}