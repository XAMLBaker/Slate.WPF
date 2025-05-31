using System;
using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public abstract class FlexStack : StackPanel
    {
        public double Spacing
        {
            get { return (double)GetValue (SpacingProperty); }
            set { SetValue (SpacingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Spacing.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpacingProperty =
            DependencyProperty.Register ("Spacing", typeof (double), typeof (FlexStack), new PropertyMetadata (0.0, PropertyChangedCallback));
        protected override Size MeasureOverride(Size constraint)
        {
            if (this.Children.Count == 0)
                return base.MeasureOverride (constraint);


            if (Orientation == Orientation.Horizontal)
            {
                double totalDesiredWidth = 0;
                double maxDesiredHeight = 0;

                foreach (UIElement child in InternalChildren)
                {
                    // 1. 자식 Panel에게 부모(당신의 커스텀 Panel)가 제공하는 availableSize를 전달하여 측정하게 합니다.
                    // 이때, 자식 Panel은 자신의 내부 로직에 따라 자신의 DesiredSize를 계산할 것입니다.
                    // 예를 들어, 자식 Panel도 자신의 자식들의 크기를 합산하거나, Stretch 동작을 하거나 할 것입니다.
                    child.Measure (constraint);

                    // 2. 자식 Panel의 DesiredSize를 얻습니다.
                    // 이 DesiredSize는 자식 Panel이 원하는 '최소한의 크기'입니다.
                    // Width나 Height 속성이 NaN인 경우에도 DesiredSize는 유효한 값을 가집니다.
                    // 예를 들어, 자식 Panel 안에 TextBlock이 있다면, TextBlock의 크기에 따라 DesiredSize가 계산됩니다.


                    Size childDesiredSize = child.DesiredSize;

                    totalDesiredWidth += childDesiredSize.Width;
                    maxDesiredHeight = Math.Max (maxDesiredHeight, childDesiredSize.Height);
                }
                return new Size (
                                    double.IsPositiveInfinity (constraint.Width) ? totalDesiredWidth : Math.Min (totalDesiredWidth, constraint.Width),
                                    double.IsPositiveInfinity (constraint.Height) ? maxDesiredHeight : Math.Min (maxDesiredHeight, constraint.Height)
                                );
            }

            double totalDesiredHeight = 0;
            double maxDesiredWidth = 0;

            foreach (UIElement child in InternalChildren)
            {
                // 1. 자식 Panel에게 부모(당신의 커스텀 Panel)가 제공하는 availableSize를 전달하여 측정하게 합니다.
                // 이때, 자식 Panel은 자신의 내부 로직에 따라 자신의 DesiredSize를 계산할 것입니다.
                // 예를 들어, 자식 Panel도 자신의 자식들의 크기를 합산하거나, Stretch 동작을 하거나 할 것입니다.
                child.Measure (constraint);

                // 2. 자식 Panel의 DesiredSize를 얻습니다.
                // 이 DesiredSize는 자식 Panel이 원하는 '최소한의 크기'입니다.
                // Width나 Height 속성이 NaN인 경우에도 DesiredSize는 유효한 값을 가집니다.
                // 예를 들어, 자식 Panel 안에 TextBlock이 있다면, TextBlock의 크기에 따라 DesiredSize가 계산됩니다.


                Size childDesiredSize = child.DesiredSize;

                maxDesiredWidth = Math.Max (maxDesiredWidth, childDesiredSize.Width);
                totalDesiredHeight += childDesiredSize.Height;
            }
            double width = 0.0;
            if(Double.IsInfinity(this.Width) || Double.IsInfinity(this.Width) || Double.IsNaN(this.Width))
            {
                if (double.IsPositiveInfinity (constraint.Width))
                {
                    width = maxDesiredWidth;
                }
                else
                {
                    width = Math.Min (maxDesiredWidth, constraint.Width);
                }
            }
            else
            {
                width = this.Width;
            }

                return new Size (
                                   width,
                                    double.IsPositiveInfinity (constraint.Height) ? totalDesiredHeight : Math.Min (totalDesiredHeight, constraint.Height)
                                );

        }

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

        protected abstract void Arrange(Size finalSize);
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
        protected FlexStack()
        {
        }
    }
    public class HStack : FlexStack
    {
        public HStack()
        {
            this.Orientation = Orientation.Horizontal;
        }

        protected override void Arrange(Size finalSize)
        {
            if (InternalChildren.Count == 0)
                return;

            if (InternalChildren.Count == 1)
                return;

            double offset = 0.0;
            for (int i = 0; i < InternalChildren.Count; i++)
            {
                FrameworkElement child = (FrameworkElement)this.Children[i];

                Rect childRect = new Rect (offset, 0, child.DesiredSize.Width, finalSize.Height);

                child.Arrange (childRect);

                offset += child.DesiredSize.Width + Spacing;
            }
        }
    }
}
