using System.Windows.Data;


namespace Slate.WPF.Markup
{
    public static class ControlExtensions
    {
        public static T Background<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.BackgroundProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Template<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.TemplateProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T TabIndex<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.TabIndexProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Padding<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.PaddingProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T IsTabStop<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.IsTabStopProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T HorizontalContentAlignment<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.HorizontalContentAlignmentProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T VerticalContentAlignment<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.VerticalContentAlignmentProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T FontWeight<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.FontWeightProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T FontStyle<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.FontStyleProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T FontStretch<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.FontStretchProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T FontSize<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.FontSizeProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T FontFamliy<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.FontFamilyProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T BorderBrush<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.BorderBrushProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T BorderThickness<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.BorderThicknessProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T Foreground<T>(this T control, IState state) where T : Control
        {
            return control.Binding (Control.ForegroundProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
    }
}
