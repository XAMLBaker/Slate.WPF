using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FlexMVVM.WPF.Markup
{
    public static class BindingExtensions
    {
        public static T Link<T>(
                        this T control,
                        DependencyProperty property,
                        string path,
                        object source = null,
                        IValueConverter? converter = null) where T : FrameworkElement
        {
            var binding = new Binding (path)
            {
                Source = source,
                Converter = converter
            };

            control.SetBinding (property, binding);
            return control;
        }


        public static ContentControl Link(this ContentControl control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            control.SetBinding (ContentControl.ContentProperty, binding);
            return control;
        }
        public static TextBlock Link(this TextBlock control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            control.SetBinding (TextBlock.TextProperty, binding);
            return control;
        }
        public static ItemsControl Link(this ItemsControl control, string viewModelProperty)
        {
            control.SetBinding (Selector.ItemsSourceProperty, new Binding (viewModelProperty));
            return control;
        }
    }
    public static class CommonElementExtentions
    {
        public static UIElement OnTapped(this UIElement element, Action action)
        {
            if (element.GetType ().BaseType == typeof (ButtonBase))
            {
                ((ButtonBase)element).Click += (_, __) => action ();
                return element;
            }
            element.MouseLeftButtonDown += (_, __) => action ();

            return element;
        }

        public static UIElement OnTappedAsync(this UIElement element, Func<Task> asyncAction)
        {
            element.MouseLeftButtonDown += async (_, __) => await asyncAction ();

            return element;
        }

        public static UIElement OnHover(this UIElement element, Action action)
        {
            element.MouseEnter += (_, __) => action ();
            return element;
        }
        public static UIElement OnRelease(this UIElement element, Action action)
        {
            element.MouseLeave += (_, __) => action ();
            return element;
        }
        public static UIElement OnHover(this UIElement element, Action<UIElement> action)
        {
            element.MouseEnter += (_, __) => action (element);
            return element;
        }
        public static UIElement OnRelease(this UIElement element, Action<UIElement> action)
        {
            element.MouseLeave += (_, __) => action (element);
            return element;
        }
    }
    public static class TextBoxExtentions
    {
        public static T OnFocus<T>(this T element, Action action) where T : TextBox
        {
            element.GotFocus += (_, __) => action ();
            return element;
        }
        public static T OnLostFocus<T>(this T element, Action action) where T : TextBox
        {
            element.LostFocus += (_, __) => action ();
            return element;
        }
        public static T OnFocus<T>(this T element, Action<T> action) where T : TextBox
        {
            element.GotFocus += (_, __) => action (element);
            return element;
        }
        public static T OnLostFocus<T>(this T element, Action<T> action) where T : TextBox
        {
            element.LostFocus += (_, __) => action (element);
            return element;
        }
        public static T OnPreviewText<T>(this T tb, Action action) where T : TextBox
        {
            tb.PreviewTextInput += (_, __) => action ();

            return tb;
        }
        public static T SelectionBrush<T>(this T tb, string colorString) where T : TextBox
        {
            tb.SelectionBrush (ColorTool.Get (colorString));
            return tb;
        }
        public static T SelectionBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.SelectionBrush = new SolidColorBrush (color);
            return tb;
        }
        public static T SelectionTextBrush<T>(this T tb, string colorString) where T : TextBox
        {
            tb.SelectionTextBrush(ColorTool.Get (colorString));

            return tb;
        }
        public static T SelectionTextBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.SelectionTextBrush = new SolidColorBrush (color);
            return tb;
        }
    }

    
  
    public static class FlexCheckBoxExtentions
    {
        public static T CheckBoxColor<T>(this T fcb, Color color) where T : FlexCheckBox
        {
            fcb.Color = new SolidColorBrush (color);
            return fcb;
        }
        public static T CheckBoxColor<T>(this T fcb, string color) where T : FlexCheckBox
        {
            fcb.Color = BrushTool.Get (color);
            return fcb;
        }

        public static T CheckBoxColor<T>(this T fcb, Brush color) where T : FlexCheckBox
        {
            if (color == null)
                return fcb;
            fcb.Color = color;
            return fcb;
        }
        public static T CheckColor<T>(this T fcb, Color color) where T : FlexCheckBox
        {
            fcb.ForeColor = new SolidColorBrush (color);
            return fcb;
        }
        public static T CheckColor<T>(this T fcb, string color) where T : FlexCheckBox
        {
            fcb.ForeColor = BrushTool.Get (color);
            return fcb;
        }
        public static T CheckColor<T>(this T fcb, Brush color) where T : FlexCheckBox
        {
            if (color == null)
                return fcb;
            fcb.ForeColor = color;
            return fcb;
        }

        public static T CheckBoxSize<T>(this T fcb, double value) where T : FlexCheckBox
        {
            fcb.CheckBoxSize = value;
            return fcb;
        }
        public static T CornerRadius<T>(this T fcb, double marginAll = 0) where T : FlexCheckBox
        {
            fcb.CornerRadius = new CornerRadius (marginAll, marginAll, marginAll, marginAll);
            return fcb;
        }
        public static T CornerRadius<T>(this T fcb, double leftright = 0, double topbottom = 0) where T : FlexCheckBox
        {
            fcb.CornerRadius = new CornerRadius (leftright, topbottom, leftright, topbottom);
            return fcb;
        }
        public static T CornerRadius<T>(this T fcb, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : FlexCheckBox
        {
            fcb.CornerRadius = new CornerRadius (left, top, right, bottom);

            return fcb;
        }

        public static T CornerRadius<T>(this T fcb, CornerRadius radius) where T : FlexCheckBox
        {
            fcb.CornerRadius = radius;

            return fcb;
        }
        public static T HoverBrush<T>(this T fcb, string color) where T : FlexCheckBox
        {
            fcb.HoverBrush = BrushTool.Get (color);

            return fcb;
        }

        public static T HoverBrush<T>(this T fcb, Color color) where T : FlexCheckBox
        {
            fcb.HoverBrush = new SolidColorBrush (color);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, string baseColor, string hoverColor) where T : FlexCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, string baseColor, Color hoverColor) where T : FlexCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, Color baseColor, string hoverColor) where T : FlexCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, Color baseColor, Color hoverColor) where T : FlexCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, Brush baseColor, Brush hoverColor) where T : FlexCheckBox
        {
            fcb.BorderBrush = baseColor;
            fcb.HoverBrush = hoverColor;

            return fcb;
        }
        public static T BoxStyle<T>(this T fcb, Func<FlexCheckBoxModel> action) where T : FlexCheckBox
        {
            var model = action ();
            fcb.Padding (model.PaddingValue);
            fcb.CheckBoxColor (model.BackColorValue);
            fcb.CheckColor (model.CheckColorValue);
            fcb.BorderThickness (model.ThicknessValue);
            fcb.CheckBoxSize (model.SizeValue);
            fcb.CornerRadius (model.CornerRadiusValue);
            fcb.BorderBrush (model.BorderBrushValue, model.HoverBorderBrushValue);
            return fcb;
        }
    }

    public static class FlexPanelExtentions
    {
        /// <summary>
        /// height가 설정되었거나 되지 않아도 height값을 추가적으로 더할 수 있습니다.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fp"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T AddHeight<T>(this T fp, double value) where T : FlexPanel
        {
            fp.AddHeight = value;
            return fp;
        }
        public static T Justify<T>(this T fp, JustifyContent justify) where T : FlexPanel
        {
            fp.Justify = justify;
            return fp;
        }

        public static T Align<T>(this T fp, AlignContent align) where T : FlexPanel
        {
            fp.Align = align;
            return fp;
        }
    }

    public static class FlexControlExtentions
    {
        public static T WaterMarkText<T>(this T ftb, string text) where T : FlexTextBox
        {
            ftb.WaterMarkText = text;
            return ftb;
        }
        public static T WaterMarkTextColor<T>(this T ftb, string colorString) where T : FlexTextBox
        {
            ftb.WaterMarkTextColor = BrushTool.Get (colorString);

            return ftb;
        }

        public static T WaterMarkTextColor<T>(this T ftb, Color color) where T : FlexTextBox
        {
            ftb.WaterMarkTextColor = new SolidColorBrush (color);

            return ftb;
        }

        public static T CornerRadius<T>(this T fc, double marginAll = 0) where T : IFlexControl
        {
            fc.CornerRadius = new CornerRadius (marginAll, marginAll, marginAll, marginAll);
            return fc;
        }
        public static T CornerRadius<T>(this T fc, double leftright = 0, double topbottom = 0) where T : IFlexControl
        {
            fc.CornerRadius = new CornerRadius (leftright, topbottom, leftright, topbottom);
            return fc;
        }
        public static T CornerRadius<T>(this T fc, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : IFlexControl
        {
            fc.CornerRadius = new CornerRadius (left, top, right, bottom);

            return fc;
        }

        public static T HoverBackgroundAnimation<T>(this T fc, Color color, int interval) where T : IFlexControl
        {
            fc.HoverBackground = color;
            fc.HoverBackgroundAnimationInterval = interval;
            return fc;
        }

        public static T HoverBackgroundAnimation<T>(this T fc, string color, int interval) where T : IFlexControl
        {
            fc.HoverBackground = ColorTool.Get (color);
            fc.HoverBackgroundAnimationInterval = interval;
            return fc;
        }

        public static T HoverBorderBrushAnimation<T>(this T fc, Color color, int interval) where T : IFlexControl
        {
            fc.HoverBorderBrush = color;
            fc.HoverBorderBrushAnimationInterval = interval;
            return fc;
        }

        public static T HoverBorderBrushAnimation<T>(this T fc, string color, int interval) where T : IFlexControl
        {
            fc.HoverBorderBrush = ColorTool.Get(color);
            fc.HoverBorderBrushAnimationInterval = interval;
            return fc;
        }

        public static T FocusBorderBrushAnimation<T>(this T fc, Color color, int interval) where T : IFlexControl
        {
            fc.FocusBorderBrush = color;
            fc.FocusBorderBrushAnimationInterval = interval;
            return fc;
        }

        public static T FocusBorderBrushAnimation<T>(this T fc, string color, int interval) where T : IFlexControl
        {
            fc.FocusBorderBrush = ColorTool.Get (color);
            fc.FocusBorderBrushAnimationInterval = interval;
            return fc;
        }

        public static T Orientation<T>(this T fd, Orientation orientation) where T : FlexDivider
        {
            fd.Orientation = orientation;
            return fd;
        }

        public static T StartIndent<T>(this T fd, double value) where T : FlexDivider
        {
            fd.StartIndent = value;
            return fd;
        }

        public static T EndIndent<T>(this T fd, double value) where T : FlexDivider
        {
            fd.EndIndent = value;
            return fd;
        }

        public static T Thickness<T>(this T fd, double value) where T : FlexDivider
        {
            fd.Thickness = value;
            return fd;
        }
    }
}
