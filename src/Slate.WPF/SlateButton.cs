using System.Windows;

namespace Slate.WPF
{
    public class SlateButton : System.Windows.Controls.Button, ISlateControl
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue (CornerRadiusProperty); }
            set { SetValue (CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (SlateButton), new PropertyMetadata (new CornerRadius (0)));

        static SlateButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (SlateButton), new FrameworkPropertyMetadata (typeof (SlateButton)));
        }
    }
}
