using System;
using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public class FlexStack : StackPanel
    {
        public double Spacing
        {
            get { return (double)GetValue (SpacingProperty); }
            set { SetValue (SpacingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Spacing.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpacingProperty =
            DependencyProperty.Register ("Spacing", typeof (double), typeof (FlexStack), new PropertyMetadata (0.0, PropertyChangedCallback));

        protected override Size ArrangeOverride(Size arrangeSize)
        {
            Arrange (arrangeSize);
            return base.ArrangeOverride (arrangeSize);
        }

        protected override void OnChildDesiredSizeChanged(UIElement child)
        {
            base.OnChildDesiredSizeChanged (child);
            Arrange (this.RenderSize);
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged (sizeInfo);
            Arrange (this.RenderSize);
        }

        private void Arrange(Size finalSize)
        {
            if (InternalChildren.Count == 0)
                return;

            if (InternalChildren.Count == 1)
                return;

            for (int i = 0; i < InternalChildren.Count - 1; i++)
            {
                FrameworkElement child = (FrameworkElement)this.Children[i];
                child.SetValue (MarginProperty, new Thickness (0, 0, Spacing, 0));
            }
        }

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue == e.NewValue)
                return;
            try
            {
                var FlexStack = ((FlexStack)d);

                FlexStack.Arrange (FlexStack.RenderSize);
            }
            catch (Exception ex)
            {

            }
        }
    }
    public class HStack : FlexStack
    {
        public HStack()
        {
            this.Orientation = Orientation.Horizontal;
        }
    }
}
