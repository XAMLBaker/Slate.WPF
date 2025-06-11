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
            DependencyProperty.Register ("Spacing", typeof (double), typeof (FlexStack), new PropertyMetadata (0.0));
        protected override Size MeasureOverride(Size constraint)
        {
            double width = 0;
            double height = 0;
            double stackedWidth = 0;
            double stackedHeight = 0;

            foreach (UIElement child in InternalChildren)
            {
                if (child == null)
                    continue;

                child.Measure (constraint);

                Size childSize = child.DesiredSize;

                if (Orientation == Orientation.Vertical)
                {
                    stackedHeight += childSize.Height + Spacing;
                    width = Math.Max (width, childSize.Width);
                }
                else
                {
                    stackedWidth += childSize.Width + Spacing;
                    height = Math.Max (height, childSize.Height);
                }
            }

            if (InternalChildren.Count > 0)
            {
                if (Orientation == Orientation.Vertical)
                    stackedHeight -= Spacing;
                else
                    stackedWidth -= Spacing;
            }

            return Orientation == Orientation.Vertical
                ? new Size (width, stackedHeight)
                : new Size (stackedWidth, height);

        }
    }
    public class HStack : FlexStack
    {
        public HStack()
        {
            this.Orientation = Orientation.Horizontal;
        }
        public HStack(double spacing) : this()
        {
            this.Spacing = spacing;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            double offset = 0;
            foreach (UIElement child in InternalChildren)
            {
                if (child == null)
                    continue;

                Size childSize = child.DesiredSize;

                child.Arrange (new Rect (offset, 0, childSize.Width, finalSize.Height));
                offset += childSize.Width + Spacing;
            }

            if (InternalChildren.Count > 0)
                offset -= Spacing;

            return Orientation == Orientation.Vertical
                ? new Size (finalSize.Width, offset)
                : new Size (offset, finalSize.Height);
        }
    }
}
