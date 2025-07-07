using Windows.UI;

namespace MarkupChain.WinUI3.Controls.Primitives;

public static class ColorSpectrumExtensions
{
    public static T Color<T>(this T colorSpectrum, Color color)
        where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.ColorProperty, color);
        return colorSpectrum;
    }
    
    public static T Components<T>(this T colorSpectrum, ColorSpectrumComponents components)
        where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.ComponentsProperty, components);
        return colorSpectrum;
    }
    
    public static T HsvColor<T>(this T colorSpectrum, Color hsvColor)
        where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.HsvColorProperty, hsvColor);
        return colorSpectrum;
    }
    
    public static T MaxHue<T>(this T colorSpectrum, int maxHue) where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.MaxHueProperty, maxHue);
        return colorSpectrum;
    }
    
    public static T MaxSaturation<T>(this T colorSpectrum, int maxSaturation) where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.MaxSaturationProperty, maxSaturation);
        return colorSpectrum;
    }
    
    public static T MaxValue<T>(this T colorSpectrum, int maxValue) where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.MaxValueProperty, maxValue);
        return colorSpectrum;
    }
    
    public static T MinHue<T>(this T colorSpectrum, int minHue) where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.MinHueProperty, minHue);
        return colorSpectrum;
    }
    
    public static T MinSaturation<T>(this T colorSpectrum, int minSaturation) where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.MinSaturationProperty, minSaturation);
        return colorSpectrum;
    }
    
    public static T MinValue<T>(this T colorSpectrum, int minValue) where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.MinValueProperty, minValue);
        return colorSpectrum;
    }
 
    public static T Shape<T>(this T colorSpectrum, ColorSpectrumShape shape)
        where T : ColorSpectrum
    {
        colorSpectrum.SetValue(ColorSpectrum.ShapeProperty, shape);
        return colorSpectrum;
    }
}