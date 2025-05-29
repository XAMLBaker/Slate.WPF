using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public class FlexButton : Button, IFlexControl
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue (CornerRadiusProperty); }
            set { SetValue (CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (FlexButton), new PropertyMetadata (new CornerRadius (0)));

        static FlexButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FlexButton), new FrameworkPropertyMetadata (typeof (FlexButton)));
        }
    }
}
