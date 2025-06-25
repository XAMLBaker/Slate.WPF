using Windows.UI.Text;

namespace MarkupChain.WinUI3;

//an extension class which able to chaining -Property(=DependencyProperty) affix Properties.
public static class ControlExtensions
{
    public static T Background<T>(this T control, Brush color) where T : Control
    {
        control.SetValue(Control.BackgroundProperty, color);
        return control;
    }

    public static T BackgroundSizing<T>(this T control, BackgroundSizing backgroundSizing) where T : Control
    {
        control.SetValue(Control.BackgroundSizingProperty, backgroundSizing);
        return control;
    }

    public static T BorderBrush<T>(this T control, Brush color) where T : Control
    {
        control.SetValue(Control.BorderBrushProperty, color);
        return control;
    }

    public static T BorderThickness<T>(this T control, Thickness thickness) where T : Control
    {
        control.SetValue(Control.BorderThicknessProperty, thickness);
        return control;
    }

    public static T CharacterSpacing<T>(this T control, int spacing) where T : Control
    {
        control.SetValue(Control.CharacterSpacingProperty, spacing);
        return control;
    }
    
    public static T CornerRadius<T>(this T control, CornerRadius cornerRadius) where T : Control
    {
        control.SetValue(Control.CornerRadiusProperty, cornerRadius);
        return control;
    }
    
    public static T DefaultStyleKey<T>(this T control, object key) where T : Control
    {
        control.SetValue(Control.DefaultStyleKeyProperty, key);
        return control;
    }
    
    public static T DefaultStyleResourceUri<T>(this T control, Uri uri) where T : Control
    {
        control.SetValue(Control.DefaultStyleResourceUriProperty, uri);
        return control;
    }
    
    public static T ElementSoundMode<T>(this T control, ElementSoundMode mode) where T : Control
    {
        control.SetValue(Control.ElementSoundModeProperty, mode);
        return control;
    }
    
    public static T FontFamily<T>(this T control, FontFamily fontFamily) where T : Control
    {
        control.SetValue(Control.FontFamilyProperty, fontFamily);
        return control;
    }
    
    public static T FontSize<T>(this T control, double size) where T : Control
    {
        control.SetValue(Control.FontSizeProperty, size);
        return control;
    }
    
    public static T FontStretch<T>(this T control, FontStretch stretch) where T : Control
    {
        control.SetValue(Control.FontStretchProperty, stretch);
        return control;
    }
    
    public static T FontStyle<T>(this T control, FontStyle style) where T : Control
    {
        control.SetValue(Control.FontStyleProperty, style);
        return control;
    }
    
    public static T FontWeight<T>(this T control, FontWeight weight) where T : Control
    {
        control.SetValue(Control.FontWeightProperty, weight);
        return control;
    }
    
    public static T Foreground<T>(this T control, Brush color) where T : Control
    {
        control.SetValue(Control.ForegroundProperty, color);
        return control;
    }
    
    public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment alignment) where T : Control
    {
        control.SetValue(Control.HorizontalContentAlignmentProperty, alignment);
        return control;
    }
    
    public static T IsEnabled<T>(this T control, bool isEnabled) where T : Control
    {
        control.SetValue(Control.IsEnabledProperty, isEnabled);
        return control;
    }
    
    public static T IsFocusEngaged<T>(this T control, bool isFocusEngaged) where T : Control
    {
        control.SetValue(Control.IsFocusEngagedProperty, isFocusEngaged);
        return control;
    }
    
    public static T IsFocusEngagementEnabled<T>(this T control, bool isFocusEngagementEnabled) where T : Control
    {
        control.SetValue(Control.IsFocusEngagementEnabledProperty, isFocusEngagementEnabled);
        return control;
    }
    
    public static T IsTemplateFocusTarget<T>(this T control, bool isTemplateFocusTarget) where T : Control
    {
        control.SetValue(Control.IsTemplateFocusTargetProperty, isTemplateFocusTarget);
        return control;
    }
    
    public static T IsTemplateKeyTipTarget<T>(this T control, bool isTemplateKeyTipTarget) where T : Control
    {
        control.SetValue(Control.IsTemplateKeyTipTargetProperty, isTemplateKeyTipTarget);
        return control;
    }
    
    public static T IsTextScaleFactorEnabled<T>(this T control, bool isTextScaleFactorEnabled) where T : Control
    {
        control.SetValue(Control.IsTextScaleFactorEnabledProperty, isTextScaleFactorEnabled);
        return control;
    }
    
    public static T Padding<T>(this T control, Thickness padding) where T : Control
    {
        control.SetValue(Control.PaddingProperty, padding);
        return control;
    }
    
    public static T RequiresPointer<T>(this T control, bool requiresPointer) where T : Control
    {
        control.SetValue(Control.RequiresPointerProperty, requiresPointer);
        return control;
    }
    
    public static T TabNavigation<T>(this T control, KeyboardNavigationMode mode) where T : Control
    {
        control.SetValue(Control.TabNavigationProperty, mode);
        return control;
    }
    
    public static T Template<T>(this T control, ControlTemplate template) where T : Control
    {
        control.SetValue(Control.TemplateProperty, template);
        return control;
    }
    
    public static T VerticalContentAlignment<T>(this T control, VerticalAlignment alignment) where T : Control
    {
        control.SetValue(Control.VerticalContentAlignmentProperty, alignment);
        return control;
    }
}