using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FlexMVVM.WPF
{
    public class FlexCheckBox : CheckBox
    {
        public Brush HoverBrush
        {
            get { return (Brush)GetValue (HoverBrushProperty); }
            set { SetValue (HoverBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FocusBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBrushProperty =
            DependencyProperty.Register ("HoverBrush", typeof (Brush), typeof (FlexCheckBox), new PropertyMetadata (new SolidColorBrush (Colors.LightGray)));
        public double CheckBoxSize
        {
            get { return (double)GetValue (CheckBoxSizeProperty); }
            set { SetValue (CheckBoxSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckBoxWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckBoxSizeProperty =
            DependencyProperty.Register ("CheckBoxSize", typeof (double), typeof (FlexCheckBox), new PropertyMetadata (12.0));


        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue (CornerRadiusProperty); }
            set { SetValue (CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (FlexCheckBox), new PropertyMetadata (new CornerRadius (0)));
        public Brush Color
        {
            get { return (Brush)GetValue (ColorProperty); }
            set { SetValue (ColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register ("Color", typeof (Brush), typeof (FlexCheckBox), new PropertyMetadata (new SolidColorBrush (Colors.White)));

        public Brush ForeColor
        {
            get { return (Brush)GetValue (ForeColorProperty); }
            set { SetValue (ForeColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForeColorProperty =
            DependencyProperty.Register ("ForeColor", typeof (Brush), typeof (FlexCheckBox), new PropertyMetadata (new SolidColorBrush (Colors.Black)));

        public string CheckMarkData
        {
            get { return (string)GetValue (CheckMarkDataProperty); }
            set { SetValue (CheckMarkDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckMarkDataProperty =
            DependencyProperty.Register ("CheckMarkData", typeof (string), typeof (FlexCheckBox), new PropertyMetadata (OnCheckmarkDataChanged));



        public string InderminateMarkData
        {
            get { return (string)GetValue (InderminateMarkDataProperty); }
            set { SetValue (InderminateMarkDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InderminateMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InderminateMarkDataProperty =
            DependencyProperty.Register ("InderminateMarkData", typeof (string), typeof (FlexCheckBox), new PropertyMetadata (OnInderminateMarkDataChanged));


        private static void OnCheckmarkDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue == e.NewValue)
                return;

            ((FlexCheckBox)d)._checkMarkPath.Data = PathExtentions.Data ((string)e.NewValue);
        }
        private static void OnInderminateMarkDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue == e.NewValue)
                return;

            ((FlexCheckBox)d)._inderminateMarkPath.Data = PathExtentions.Data ((string)e.NewValue);
        }

        public Path _checkMarkPath;
        public Path _inderminateMarkPath;
        static FlexCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FlexCheckBox), new FrameworkPropertyMetadata (typeof (FlexCheckBox)));
        }
        public FlexCheckBox()
        {

        }

        protected override void OnChecked(RoutedEventArgs e)
        {
            base.OnChecked (e);
        }
        private Brush baseBrush;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate ();

            if (GetTemplateChild ("CheckMark") is Path check)
            {
                check.Data = PathExtentions.Data ("M21,7L9,19L3.5,13.5L4.91,12.09L9,16.17L19.59,5.59L21,7Z");
                _checkMarkPath = check;
            }

            if (GetTemplateChild ("InderminateMark") is Path inderminate)
            {
                inderminate.Data = PathExtentions.Data ("M 0 7 L 7 0");
                _inderminateMarkPath = inderminate;
            }
            this.baseBrush = this.BorderBrush;
            this.MouseEnter += (s, e) =>
            {
                this.BorderBrush = this.HoverBrush;
            };

            this.MouseLeave += (s, e) =>
            {
                this.BorderBrush = this.baseBrush;
            };
        }
    }
}
