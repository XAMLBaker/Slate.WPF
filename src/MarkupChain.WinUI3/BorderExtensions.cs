using Microsoft.UI.Xaml.Media.Animation;

namespace MarkupChain.WinUI3;

public static class BorderExtensions
{
    public static Border Background(this Border bdr, Brush color)
    {
        bdr.SetValue(Border.BackgroundProperty, color);
        return bdr;
    }

    public static Border BackgroundSizing(this Border bdr, BackgroundSizing backgroundSizing)
    {
        bdr.SetValue(Border.BackgroundSizingProperty, backgroundSizing);
        return bdr;
    }

    public static Border Padding(this Border bdr, Thickness padding)
    {
        bdr.SetValue(Border.PaddingProperty, padding);
        return bdr;
    }

    public static Border CornerRadius(this Border bdr, CornerRadius cornerRadius)
    {
        bdr.SetValue(Border.CornerRadiusProperty, cornerRadius);
        return bdr;
    }

    public static Border BorderBrush(this Border bdr, Brush color)
    {
        bdr.SetValue(Border.BorderBrushProperty, color);
        return bdr;
    }

    public static Border BorderThickness(this Border bdr, Thickness padding)
    {
        bdr.SetValue(Border.BorderThicknessProperty, padding);
        return bdr;
    }
    
    public static Border ChildTransitionsProperty(this Border bdr, TransitionCollection transitions)
    {
        bdr.SetValue(Border.ChildTransitionsProperty, transitions);
        return bdr;
    }
}