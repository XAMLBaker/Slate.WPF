using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF
{
    public interface IFlexControl
    {
        CornerRadius CornerRadius { get; set; }
    }
    public class FlexTextBox : TextBox, IFlexControl
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue (CornerRadiusProperty); }
            set { SetValue (CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (FlexTextBox), new PropertyMetadata (new CornerRadius (0)));


        public string WaterMarkText
        {
            get { return (string)GetValue (WaterMarkTextProperty); }
            set { SetValue (WaterMarkTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkTextProperty =
            DependencyProperty.Register ("WaterMark", typeof (string), typeof (FlexTextBox), new PropertyMetadata (null));



        public Brush WaterMarkTextColor
        {
            get { return (Brush)GetValue (WaterMarkTextColorProperty); }
            set { SetValue (WaterMarkTextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterMarkTextColorProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkTextColorProperty =
            DependencyProperty.Register ("WaterMarkTextColor", typeof (Brush), typeof (FlexTextBox), new PropertyMetadata (new SolidColorBrush (Colors.Red)));

        static FlexTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FlexTextBox), new FrameworkPropertyMetadata (typeof (FlexTextBox)));
        }
    }
}
