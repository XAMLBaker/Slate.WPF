using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public class FlexRegion : ContentControl
    {
        public string RegionName
        {
            get { return (string)GetValue (RegionNameProperty); }
            set { SetValue (RegionNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RegionName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegionNameProperty =
     DependencyProperty.Register (nameof (RegionName), typeof (string), typeof (FlexRegion),
         new PropertyMetadata (null, OnRegionNameChanged));
        private static void OnRegionNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FlexRegion host && e.NewValue is string newName)
            {
                RegionManager.RegisterRegion (newName, host);
            }
        }

        public FlexRegion()
        {
            
        }
        public FlexRegion(string regionName)
        {
            this.RegionName = regionName;
        }

        private UIElement element;
        public void RegisterControl<T>()
        {
            element = (UIElement)RegisterProvider.Get<T> ();
            RegionManager.Attach (this.RegionName, element);
        }

        public void Set()
        {
            RegionManager.Attach (this.RegionName, element);
        }
        public void DSet()
        {
            RegionManager.Detach (this.RegionName);
        }
    }

    public static class FlexRegionExtentions
    {
        public static FlexRegion BindingControl<T> (this FlexRegion control)
        {
            control.RegisterControl<T> ();
            return control;
        }
    }
}
