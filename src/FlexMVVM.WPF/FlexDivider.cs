using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FlexMVVM.WPF
{
    public class FlexDivider : ContentControl
    {
        public Orientation Orientation
        {
            get { return (Orientation)GetValue (OrientationProperty); }
            set { SetValue (OrientationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Orientation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register ("Orientation", typeof (Orientation), typeof (FlexDivider), new PropertyMetadata (Orientation.Horizontal, PropertyChangedCallback));


        public double StartIndent
        {
            get { return (double)GetValue (StartIndentProperty); }
            set { SetValue (StartIndentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Indent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartIndentProperty =
            DependencyProperty.Register ("StartIndent", typeof (double), typeof (FlexDivider), new PropertyMetadata (0.0, PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue == e.NewValue)
                return;

            ((FlexDivider)d).DividerMake ();
        }

        public double EndIndent
        {
            get { return (double)GetValue (EndIndentProperty); }
            set { SetValue (EndIndentProperty, value); }
        }


        public double Thickness
        {
            get { return (double)GetValue (ThicknessProperty); }
            set { SetValue (ThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register ("Thickness", typeof (double), typeof (FlexDivider), new PropertyMetadata (1.0, PropertyChangedCallback));



        // Using a DependencyProperty as the backing store for Indent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EndIndentProperty =
            DependencyProperty.Register ("EndIndent", typeof (double), typeof (FlexDivider), new PropertyMetadata (0.0, PropertyChangedCallback));



        static FlexDivider()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FlexDivider), new FrameworkPropertyMetadata (typeof (FlexDivider)));
        }
        private Line _line;
        private double lastValue = 0.0;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate ();

            _line =  this.GetTemplateChild ("lineGeometry") as Line;

            this.LayoutUpdated += (s, e) =>
            {
                // 부모 Width가 유효한지 확인
                var parent = GetVisualParent (this);
                if (parent == null)
                    return;
                if (Orientation == Orientation.Horizontal)
                {
                    if (parent.ActualWidth > 0)
                    {
                        if (lastValue >= parent.ActualWidth)
                            return;
                        DividerMake ();
                        lastValue = parent.ActualWidth;
                    }
                }
                else if (Orientation == Orientation.Vertical)
                {
                    if (parent.ActualHeight > 0)
                    {
                        if (lastValue >= parent.ActualHeight)
                            return;
                        DividerMake ();
                        lastValue = parent.ActualHeight;
                    }
                }
            };
        }

        private void DividerMake()
        {
            if (_line == null)
                return;
            var translateTransform = new TranslateTransform ();
            var EndData = 0.0;

            if (Orientation == Orientation.Horizontal)
            {
                EndData = this.ActualWidth - (this.StartIndent + this.EndIndent);
                this.Width = EndData;
                this.Height = this.Thickness;

                translateTransform.Y = 0;
                translateTransform.X = this.StartIndent;

                _line.Y1 = EndData;
                _line.Y2 = 0;
            }
            else
            {
                EndData = this.ActualHeight - (this.StartIndent + this.EndIndent);
                this.Width = this.Thickness;
                this.Height = EndData;

                translateTransform.X = 0;
                translateTransform.Y = this.StartIndent;

                _line.Y1 = 0;
                _line.Y2 = EndData;
            }

            _line.X1 = 0;
            _line.X2 = 0;
            this.RenderTransform = translateTransform;
        }
        public FrameworkElement? GetVisualParent(DependencyObject child)
        {
            DependencyObject parent = VisualTreeHelper.GetParent (child);
            while (parent != null && !(parent is FrameworkElement))
            {
                parent = VisualTreeHelper.GetParent (parent);
            }
            return parent as FrameworkElement;
        }

    }
}
