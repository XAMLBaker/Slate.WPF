using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace FlexMVVM.WPF
{
    public interface IFlexControl
    {
        CornerRadius CornerRadius { get; set; }
        Brush Background { get; set; }
        Color? FocusBackground { get; set; }
        Color? HoverBackground { get; set; }
        Brush BorderBrush { get; set; }
        Color? FocusBorderBrush { get; set; }
        Color? HoverBorderBrush { get; set; }
        int HoverBorderBrushAnimationInterval { get; set; }
        int HoverBackgroundAnimationInterval { get; set; }
        int FocusBorderBrushAnimationInterval { get; set; }
        int FocusBackgroundAnimationInterval { get; set; }
    }
    public class FlexTextBox : TextBox, IFlexControl
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue (CornerRadiusProperty); }
            set { SetValue (CornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register ("CornerRadius", typeof (CornerRadius), typeof (FlexTextBox), new PropertyMetadata (new CornerRadius (0)));


        public string WaterMarkText
        {
            get { return (string)GetValue (WaterMarkTextProperty); }
            set { SetValue (WaterMarkTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkTextProperty =
            DependencyProperty.Register ("WaterMark", typeof (string), typeof (FlexTextBox), new PropertyMetadata (null));



        public Brush WaterMarkTextColor
        {
            get { return (Brush)GetValue (WaterMarkTextColorProperty); }
            set { SetValue (WaterMarkTextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterMarkTextColorProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkTextColorProperty =
            DependencyProperty.Register ("WaterMarkTextColor", typeof (Brush), typeof (FlexTextBox), new PropertyMetadata (new SolidColorBrush (Colors.Red)));

        #region FocusAnimation
        public Color? FocusBackground
        {
            get { return (Color?)GetValue (FocusBackgroundProperty); }
            set { SetValue (FocusBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FocusBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FocusBackgroundProperty =
            DependencyProperty.Register ("FocusBackground", typeof (Color?), typeof (FlexTextBox), new PropertyMetadata (null));

        public int FocusBackgroundAnimationInterval
        {
            get { return (int)GetValue (FocusBackgroundAnimationIntervalProperty); }
            set { SetValue (FocusBackgroundAnimationIntervalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Interval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FocusBackgroundAnimationIntervalProperty =
            DependencyProperty.Register ("FocusBackgroundAnimationInterval", typeof (int), typeof (FlexTextBox), new PropertyMetadata (100));



        public Color? FocusBorderBrush
        {
            get { return (Color?)GetValue (FocusBorderBrushProperty); }
            set { SetValue (FocusBorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HoverBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FocusBorderBrushProperty =
            DependencyProperty.Register ("FocusBorderBrush", typeof (Color?), typeof (FlexTextBox), new PropertyMetadata (null));

        public int FocusBorderBrushAnimationInterval
        {
            get { return (int)GetValue (FocusBorderBrushAnimationIntervalProperty); }
            set { SetValue (FocusBorderBrushAnimationIntervalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Interval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FocusBorderBrushAnimationIntervalProperty =
            DependencyProperty.Register ("FocusBorderBrushAnimationInterval", typeof (int), typeof (FlexTextBox), new PropertyMetadata (100));
        #endregion
        #region HoverAnimation
        public Color? HoverBackground
        {
            get { return (Color?)GetValue (HoverBackgroundProperty); }
            set { SetValue (HoverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HoverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.Register ("HoverBackground", typeof (Color?), typeof (FlexTextBox), new PropertyMetadata (null));

        public int HoverBackgroundAnimationInterval
        {
            get { return (int)GetValue (HoverBackgroundAnimationIntervalProperty); }
            set { SetValue (HoverBackgroundAnimationIntervalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Interval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBackgroundAnimationIntervalProperty =
            DependencyProperty.Register ("HoverBackgroundAnimationInterval", typeof (int), typeof (FlexTextBox), new PropertyMetadata (100));



        public Color? HoverBorderBrush
        {
            get { return (Color?)GetValue (HoverBorderBrushProperty); }
            set { SetValue (HoverBorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HoverBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBorderBrushProperty =
            DependencyProperty.Register ("HoverBorderBrush", typeof (Color?), typeof (FlexTextBox), new PropertyMetadata (null));

        public int HoverBorderBrushAnimationInterval
        {
            get { return (int)GetValue (HoverBorderBrushAnimationIntervalProperty); }
            set { SetValue (HoverBorderBrushAnimationIntervalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Interval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBorderBrushAnimationIntervalProperty =
            DependencyProperty.Register ("HoverBorderBrushAnimationInterval", typeof (int), typeof (FlexTextBox), new PropertyMetadata (100));
        #endregion
        static FlexTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (FlexTextBox), new FrameworkPropertyMetadata (typeof (FlexTextBox)));
        }

        private FrameworkElement root;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate ();

            root = GetTemplateChild ("Border") as FrameworkElement; // VisualState가 정의된 최상위 요소
            if (root != null)
            {
                var groups = VisualStateManager.GetVisualStateGroups (root);
                var flexCommonStates = groups?.OfType<VisualStateGroup> ().FirstOrDefault (g => g.Name == "FlexCommonStates");
                if (flexCommonStates != null)
                {
                    var hoverState = flexCommonStates.States
                        .OfType<VisualState> ()
                        .FirstOrDefault (s => s.Name == "FlexMouseOver");

                    if (hoverState != null && hoverState.Storyboard == null && (HoverBackground != null || HoverBorderBrush != null))
                    {
                        var storyboard = new Storyboard ();
                        if (HoverBackground != null)
                        {
                            var anim = GetAnimation (HoverBackground, HoverBackgroundAnimationInterval);
                            Storyboard.SetTargetName (anim, "Border");
                            Storyboard.SetTargetProperty (anim, new PropertyPath ("(Border.Background).(SolidColorBrush.Color)"));

                            storyboard.Children.Add (anim);
                        }
                        if (HoverBorderBrush != null)
                        {
                            var anim = GetAnimation (HoverBorderBrush, HoverBorderBrushAnimationInterval);
                            Storyboard.SetTargetName (anim, "Border");
                            Storyboard.SetTargetProperty (anim, new PropertyPath ("(Border.BorderBrush).(SolidColorBrush.Color)"));

                            storyboard.Children.Add (anim);
                        }

                        hoverState.Storyboard = storyboard;
                    }
                    var focuseState = flexCommonStates.States
                        .OfType<VisualState> ()
                        .FirstOrDefault (s => s.Name == "FlexFocused");

                    if (focuseState != null && focuseState.Storyboard == null && (FocusBackground != null || FocusBorderBrush != null))
                    {
                        var storyboard = new Storyboard ();

                        if (FocusBackground != null)
                        {
                            var anim = GetAnimation (FocusBackground, FocusBackgroundAnimationInterval);
                            Storyboard.SetTargetName (anim, "Border");
                            Storyboard.SetTargetProperty (anim, new PropertyPath ("(Border.Background).(SolidColorBrush.Color)"));

                            storyboard.Children.Add (anim);
                        }

                        if (FocusBorderBrush != null)
                        {
                            var anim = GetAnimation (FocusBorderBrush, FocusBorderBrushAnimationInterval);
                            Storyboard.SetTargetName (anim, "Border");
                            Storyboard.SetTargetProperty (anim, new PropertyPath ("(Border.BorderBrush).(SolidColorBrush.Color)"));

                            storyboard.Children.Add (anim);
                        }

                        focuseState.Storyboard = storyboard;
                    }
                }
            }


            this.MouseEnter += (s, e) =>
            {
                if (this.IsKeyboardFocused)
                {
                    return;
                }

                VisualStateManager.GoToState (this, "FlexMouseOver", true);
            };

            this.MouseLeave += (s, e) =>
            {
                if (this.IsKeyboardFocused)
                    return;

                VisualStateManager.GoToState (this, "FlexNormal", true);
            };

            this.GotFocus += (s, e) =>
            {
                VisualStateManager.GoToState (this, "FlexFocused", true);
            };

            this.LostFocus += (s, e) =>
            {
                VisualStateManager.GoToState (this, "FlexUnFocused", true);
            };
        }

        private ColorAnimation GetAnimation(Color? color, int interval)
        {
            return new ColorAnimation
            {
                To = color,
                Duration = TimeSpan.FromMilliseconds (interval)
            };
        }
    }
}
