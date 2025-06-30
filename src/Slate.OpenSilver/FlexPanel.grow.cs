using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Slate.OpenSilver
{
    public partial class FlexPanel : Panel
    {
        // flex-grow AttachedProperty
        public static readonly DependencyProperty GrowProperty =
            DependencyProperty.RegisterAttached (
                "Grow",
                typeof (double),
                typeof (FlexPanel),
                new FrameworkPropertyMetadata (0.0, FrameworkPropertyMetadataOptions.AffectsParentMeasure | FrameworkPropertyMetadataOptions.AffectsParentArrange));

        public static void SetGrow(UIElement element, double value) => element.SetValue (GrowProperty, value);
        public static double GetGrow(UIElement element) => (double)element.GetValue (GrowProperty);
    }
}
