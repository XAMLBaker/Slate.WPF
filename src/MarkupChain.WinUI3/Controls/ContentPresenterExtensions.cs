using Windows.UI.Text;

namespace MarkupChain.WinUI3.Controls;

public static class ContentPresenterExtensions
{
    public static T Background<T>(this T contentPresenter, Brush background) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.BackgroundProperty, background);
        return contentPresenter;
    }

    public static T BackgroundSizing<T>(this T contentPresenter, BackgroundSizing backgroundSizing)
        where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.BackgroundSizingProperty, backgroundSizing);
        return contentPresenter;
    }

    public static T BorderBrush<T>(this T contentPresenter, Brush borderBrush) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.BorderBrushProperty, borderBrush);
        return contentPresenter;
    }

    public static T BorderThickness<T>(this T contentPresenter, Thickness borderThickness) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.BorderThicknessProperty, borderThickness);
        return contentPresenter;
    }

    public static T CharacterSpacing<T>(this T contentPresenter, int characterSpacing) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.CharacterSpacingProperty, characterSpacing);
        return contentPresenter;
    }

    public static T Content<T>(this T contentPresenter, object content) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.ContentProperty, content);
        return contentPresenter;
    }

    public static T ContentTemplate<T>(this T contentPresenter, DataTemplate contentTemplate) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.ContentTemplateProperty, contentTemplate);
        return contentPresenter;
    }

    public static T ContentTemplateSelector<T>(this T contentPresenter, DataTemplateSelector contentTemplateSelector)
        where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.ContentTemplateSelectorProperty, contentTemplateSelector);
        return contentPresenter;
    }

    public static T ContentTransitions<T>(this T contentPresenter, TransitionCollection contentTransitions)
        where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.ContentTransitionsProperty, contentTransitions);
        return contentPresenter;
    }

    public static T CornerRadius<T>(this T contentPresenter, CornerRadius cornerRadius) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.CornerRadiusProperty, cornerRadius);
        return contentPresenter;
    }

    public static T FontFamily<T>(this T contentPresenter, FontFamily fontFamily) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.FontFamilyProperty, fontFamily);
        return contentPresenter;
    }

    public static T FontSize<T>(this T contentPresenter, double fontSize) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.FontSizeProperty, fontSize);
        return contentPresenter;
    }

    public static T FontStretch<T>(this T contentPresenter, FontStretch fontStretch) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.FontStretchProperty, fontStretch);
        return contentPresenter;
    }

    public static T FontStyle<T>(this T contentPresenter, FontStyle fontStyle) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.FontStyleProperty, fontStyle);
        return contentPresenter;
    }

    public static T FontWeight<T>(this T contentPresenter, FontWeight fontWeight) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.FontWeightProperty, fontWeight);
        return contentPresenter;
    }

    public static T Foreground<T>(this T contentPresenter, Brush foreground) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.ForegroundProperty, foreground);
        return contentPresenter;
    }

    public static T HorizontalContentAlignment<T>(this T contentPresenter,
        HorizontalAlignment horizontalContentAlignment) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.HorizontalContentAlignmentProperty, horizontalContentAlignment);
        return contentPresenter;
    }

    public static T IsTextScaleFactorEnabled<T>(this T contentPresenter, bool isTextScaleFactorEnabled)
        where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.IsTextScaleFactorEnabledProperty, isTextScaleFactorEnabled);
        return contentPresenter;
    }

    public static T LineHeight<T>(this T contentPresenter, double lineHeight) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.LineHeightProperty, lineHeight);
        return contentPresenter;
    }

    public static T LineStackingStrategy<T>(this T contentPresenter, LineStackingStrategy lineStackingStrategy)
        where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.LineStackingStrategyProperty, lineStackingStrategy);
        return contentPresenter;
    }

    public static T MaxLines<T>(this T contentPresenter, int maxLines) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.MaxLinesProperty, maxLines);
        return contentPresenter;
    }

    public static T OpticalMarginAlignment<T>(this T contentPresenter, OpticalMarginAlignment opticalMarginAlignment)
        where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.OpticalMarginAlignmentProperty, opticalMarginAlignment);
        return contentPresenter;
    }

    public static T Padding<T>(this T contentPresenter, Thickness padding) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.PaddingProperty, padding);
        return contentPresenter;
    }
    
    public static T TextLineBounds<T>(this T contentPresenter, TextLineBounds textLineBounds)
        where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.TextLineBoundsProperty, textLineBounds);
        return contentPresenter;
    }
    
    public static T TextWrapping<T>(this T contentPresenter, TextWrapping textWrapping) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.TextWrappingProperty, textWrapping);
        return contentPresenter;
    }
    
    public static T VerticalContentAlignment<T>(this T contentPresenter,
        VerticalAlignment verticalContentAlignment) where T : ContentPresenter
    {
        contentPresenter.SetValue(ContentPresenter.VerticalContentAlignmentProperty, verticalContentAlignment);
        return contentPresenter;
    }
}