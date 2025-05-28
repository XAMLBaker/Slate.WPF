using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF
{
    public enum JustifyContent
    {
        Start,
        End,
        Center,
        SpaceBetween,
        SpaceAround,
        SpaceEvenly,
        SpaceAuto
    }

    public enum AlignContent
    {
        Start,
        End,
        Center
    }

    public class FlexPanel : Panel
    {
        public JustifyContent Justify
        {
            get { return (JustifyContent)GetValue (JustifyProperty); }
            set { SetValue (JustifyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Justify.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty JustifyProperty =
            DependencyProperty.Register ("Justify", typeof (JustifyContent), typeof (FlexPanel), new PropertyMetadata (JustifyContent.Center));

        public AlignContent Align
        {
            get { return (AlignContent)GetValue (AlignProperty); }
            set { SetValue (AlignProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Justify.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AlignProperty =
            DependencyProperty.Register ("Align", typeof (AlignContent), typeof (FlexPanel), new PropertyMetadata (AlignContent.Center));

        public double AddHeight
        {
            get { return (double)GetValue (AddHeightProperty); }
            set { SetValue (AddHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AddHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddHeightProperty =
            DependencyProperty.Register ("AddHeight", typeof (double), typeof (FlexPanel), new PropertyMetadata (0.0));

        protected override Size MeasureOverride(Size constraint)
        {
            if (this.Children.Count == 0)
                return base.MeasureOverride (constraint);

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
                                double.IsPositiveInfinity (constraint.Height) ? maxDesiredHeight + AddHeight : Math.Min (maxDesiredHeight, constraint.Height) + AddHeight
                            );
        }
        protected override Size ArrangeOverride(Size finalSize)
        {
            return Make (finalSize);
        }

        private Size Make(Size finalSize)
        {
            if (InternalChildren.Count == 0)
                return finalSize;
            if (InternalChildren.Count == 1)
            {
                UIElement child = InternalChildren[0];
                child.Arrange (new Rect (0, 0, child.DesiredSize.Width, child.DesiredSize.Height));
                if (Align == AlignContent.Start)
                {
                    child.Top ();
                }
                else if (Align == AlignContent.Center)
                {
                    child.VCenter ();
                }
                else if (Align == AlignContent.End)
                {
                    child.Bottom ();
                }

                if (Justify == JustifyContent.Start)
                {
                    child.Left ();
                }
                else if (Justify == JustifyContent.Center)
                {
                    child.HCenter ();
                }
                else if (Justify == JustifyContent.End)
                {
                    child.Right ();
                }

                return finalSize;
            }

            int childrenCount = this.Children.Count;
            double totalWidth = 0.0;
            double maxWidth = 0.0;
            for (int i = 0; i < childrenCount; i++)
            {
                UIElement child = this.Children[i];
                totalWidth += child.DesiredSize.Width;
                maxWidth = maxWidth > child.DesiredSize.Width ? maxWidth : child.DesiredSize.Width;
            }
            double xOffset = 0;
            double spacing = 0;
            double remainWidth = finalSize.Width - (maxWidth * childrenCount);
            if (Justify == JustifyContent.SpaceBetween)
            {
                spacing = remainWidth / (childrenCount - 1);
            }
            else if (Justify == JustifyContent.SpaceAround)
            {
                spacing = remainWidth / (childrenCount * 2);
                xOffset = spacing;
                spacing = spacing * 2;
            }
            else if (Justify == JustifyContent.SpaceEvenly)
            {
                spacing = remainWidth / (childrenCount + 1);
                xOffset = spacing;
            }
            else if (Justify == JustifyContent.SpaceAuto)
            {
                spacing = maxWidth /2;
                xOffset = (remainWidth - (spacing * (childrenCount - 1))) /2;
            }
            else if (Justify == JustifyContent.Start)
            {
                xOffset = 0;
            }
            else if (Justify == JustifyContent.Center)
            {
                xOffset = (finalSize.Width - (maxWidth * childrenCount)) / 2;
            }
            else if (Justify == JustifyContent.End)
            {
                xOffset = finalSize.Width - (maxWidth * childrenCount);
            }

            for (int i = 0; i < childrenCount; i++)
            {
                UIElement child = this.Children[i];

                Rect childRect = new Rect (xOffset, 0, child.DesiredSize.Width, finalSize.Height);

                child.Arrange (childRect);

                if (Align == AlignContent.Start)
                {
                    child.Top ();
                }
                else if (Align == AlignContent.Center)
                {
                    child.VCenter ();
                }
                else if (Align == AlignContent.End)
                {
                    child.Bottom ();
                }

                xOffset += child.DesiredSize.Width + spacing;
            }
            return finalSize;
        }
    }
}
