using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public class FlexComponent : ContentControl
    {
        static FlexComponent()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FlexComponent), new FrameworkPropertyMetadata (typeof (FlexComponent)));
        }
    }
}
