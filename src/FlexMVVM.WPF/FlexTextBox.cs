using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF
{
    public class FlexTextBox : ContentControl
    {
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

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkTextColorProperty =
            DependencyProperty.Register ("WaterMarkTextColor", typeof (Brush), typeof (FlexTextBox), new PropertyMetadata (Colors.LightGray));

        static FlexTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FlexTextBox), new FrameworkPropertyMetadata (typeof (FlexTextBox)));
        }
    }
}
