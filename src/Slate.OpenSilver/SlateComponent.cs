using System.Windows;
using System.Windows.Controls;

namespace Slate.OpenSilver
{
    public class SlateComponent : ContentControl
    {
        static SlateComponent()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (SlateComponent), new FrameworkPropertyMetadata (typeof (SlateComponent)));
        }
    }
}
