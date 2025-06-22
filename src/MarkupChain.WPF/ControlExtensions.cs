namespace MarkupChain.WPF
{
    public static partial class ControlExtensions
    {
        public static T Background<T>(this T ctrl, Brush color) where T : Control
        {
            ctrl.SetValue (Control.BackgroundProperty, color);
            return ctrl;
        }

        public static T Template<T>(this T ctrl, ControlTemplate controlTemplate) where T : Control
        {
            ctrl.SetValue (Control.TemplateProperty, controlTemplate);
            return ctrl;
        }

        public static T TabIndex<T>(this T ctrl, int tabIndex) where T : Control
        {
            ctrl.SetValue (Control.TabIndexProperty, tabIndex);
            return ctrl;
        }

        public static T Padding<T>(this T ctrl, Thickness padding) where T : Control
        {
            ctrl.SetValue (Control.PaddingProperty, padding);
            return ctrl;
        }

        public static T IsTabStop<T>(this T ctrl, bool isTabStop) where T : Control
        {
            ctrl.SetValue (Control.IsTabStopProperty, isTabStop);
            return ctrl;
        }

        public static T HorizontalContentAlignment<T> (this T ctrl, HorizontalAlignment horizontalAlignment) where T : Control
        {
            ctrl.SetValue (Control.HorizontalContentAlignmentProperty, horizontalAlignment);
            return ctrl;
        }
        public static T VerticalContentAlignment<T>(this T ctrl, VerticalAlignment verticalContentAlignment) where T : Control
        {
            ctrl.SetValue (Control.VerticalContentAlignmentProperty, verticalContentAlignment);
            return ctrl;
        }

        public static T FontWeight<T>(this T ctrl, FontWeight value) where T : Control
        {
            ctrl.SetValue (Control.FontWeightProperty, value);
            return ctrl;
        }

        public static T FontStyle<T>(this T ctrl, FontStyle style) where T : Control
        {
            ctrl.SetValue (Control.FontStyleProperty, style);

            return ctrl;
        }
        public static T FontStretch<T>(this T ctrl, FontStretch stretch) where T : Control
        {
            ctrl.SetValue (Control.FontStretchProperty, stretch);

            return ctrl;
        }

        public static T FontSize<T>(this T ctrl, double size) where T : Control
        {
            ctrl.SetValue (Control.FontSizeProperty, size);

            return ctrl;
        }

        public static T FontFamliy<T>(this T ctrl, FontFamily fontFamliy) where T : Control
        {
            ctrl.SetValue (Control.FontFamilyProperty, fontFamliy);
            return ctrl;
        }

        public static T BorderBrush<T>(this T ctrl, Brush color) where T : Control
        {
            ctrl.SetValue (Control.BorderBrushProperty, color);
            return ctrl;
        }

        public static T BorderThickness<T>(this T ctrl, Thickness padding) where T : Control
        {
            ctrl.SetValue (Control.BorderThicknessProperty, padding);
            return ctrl;
        }

        public static T Foreground<T>(this T ctrl, Brush color) where T : Control
        {
            ctrl.SetValue (Control.ForegroundProperty, color);

            return ctrl;
        }
    }
}
