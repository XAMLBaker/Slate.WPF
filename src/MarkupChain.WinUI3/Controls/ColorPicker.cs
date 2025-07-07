using Windows.UI;

namespace MarkupChain.WinUI3.Controls;

public static class ColorPickerExtensions
{
    public static T Color<T>(this T colorPicker, Color color) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.ColorProperty, color);
        return colorPicker;
    }

    public static T ColorSpectrumComponents<T>(this T colorPicker, ColorSpectrumComponents components)
        where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.ColorSpectrumComponentsProperty, components);
        return colorPicker;
    }

    public static T IsAlphaEnabled<T>(this T colorPicker, bool isEnabled) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsAlphaEnabledProperty, isEnabled);
        return colorPicker;
    }

    public static T IsAlphaSliderVisible<T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsAlphaSliderVisibleProperty, isVisible);
        return colorPicker;
    }

    public static T IsAlphaTextInputVisible<T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsAlphaTextInputVisibleProperty, isVisible);
        return colorPicker;
    }

    public static T IsColorPreviewVisible<T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsColorPreviewVisibleProperty, isVisible);
        return colorPicker;
    }

    public static T IsColorChannelTextInputVisible<T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsColorChannelTextInputVisibleProperty, isVisible);
        return colorPicker;
    }
    
    public static T IsColorSliderVisible <T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsColorPreviewVisibleProperty, isVisible);
        return colorPicker;
    }
    
    public static T IsColorSpectrumVisible<T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsColorSpectrumVisibleProperty, isVisible);
        return colorPicker;
    }
    
    public static T IsHexInputVisible<T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsHexInputVisibleProperty, isVisible);
        return colorPicker;
    }
    
    public static T IsMoreButtonVisible<T>(this T colorPicker, bool isVisible) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.IsMoreButtonVisibleProperty, isVisible);
        return colorPicker;
    }
    
    public static T MaxHue<T>(this T colorPicker, int maxHue) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.MaxHueProperty, maxHue);
        return colorPicker;
    }
    
    public static T MaxSaturation<T>(this T colorPicker, int maxSaturation) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.MaxSaturationProperty, maxSaturation);
        return colorPicker;
    }
    
    public static T MaxValue<T>(this T colorPicker, int maxValue) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.MaxValueProperty, maxValue);
        return colorPicker;
    }
    
    public static T MinHue<T>(this T colorPicker, int minHue) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.MinHueProperty, minHue);
        return colorPicker;
    }
    
    public static T MinSaturation<T>(this T colorPicker, int minSaturation) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.MinSaturationProperty, minSaturation);
        return colorPicker;
    }
    
    public static T MinValue<T>(this T colorPicker, int minValue) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.MinValueProperty, minValue);
        return colorPicker;
    }
    
    public static T PreviousColor<T>(this T colorPicker, Color? previousColor) where T : ColorPicker
    {
        colorPicker.SetValue(ColorPicker.PreviousColorProperty, previousColor);
        return colorPicker;
    }
}