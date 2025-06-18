using System.Windows;
using System.Windows.Media;

namespace Slate.WPF
{
    public interface ISlateControl
    {
        CornerRadius CornerRadius { get; set; }
    }
    public class SlateTextBox : System.Windows.Controls.TextBox, ISlateControl
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue (CornerRadiusProperty); }
            set { SetValue (CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (SlateTextBox), new PropertyMetadata (new CornerRadius (0)));


        public string WaterMarkText
        {
            get { return (string)GetValue (WaterMarkTextProperty); }
            set { SetValue (WaterMarkTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkTextProperty =
            DependencyProperty.Register ("WaterMark", typeof (string), typeof (SlateTextBox), new PropertyMetadata (null));



        public Brush WaterMarkTextColor
        {
            get { return (Brush)GetValue (WaterMarkTextColorProperty); }
            set { SetValue (WaterMarkTextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterMarkTextColorProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkTextColorProperty =
            DependencyProperty.Register ("WaterMarkTextColor", typeof (Brush), typeof (SlateTextBox), new PropertyMetadata (new SolidColorBrush (Colors.LightGray)));

        static SlateTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (SlateTextBox), new FrameworkPropertyMetadata (typeof (SlateTextBox)));
        }
    }
}
