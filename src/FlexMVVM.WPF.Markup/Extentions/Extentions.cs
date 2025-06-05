using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;

namespace FlexMVVM.WPF.Markup
{
    public static class BindingExtensions
    {
        public static T Link<T>(
                        this T control,
                        DependencyProperty property,
                        string path,
                        object source = null,
                        RelativeSource relativeSource = null,
                        UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
                        IValueConverter? converter = null) where T : FrameworkElement
        {
            var binding = new Binding (path);
            if(source != null)
            {
                binding.Source = source;
            }

            if(relativeSource != null)
            {
                binding.RelativeSource = relativeSource;
            }

            if (converter != null)
            {
                binding.Converter = converter;
            }

            if( updateSourceTrigger != null)
            {
                binding.UpdateSourceTrigger = updateSourceTrigger;
            }

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
            control.SetBinding (ItemsControl.ItemsSourceProperty, new Binding (viewModelProperty));
            return control;
        }
    }
    public static class ButtonBaseExtentions
    {
        //public static T OnTapped<T>(this T bb, Action action) where T : ButtonBase
        //{
        //    bb.MouseLeftButtonDown += (_, __) => action ();
        //    return bb;
        //}

        //public static T OnTappedAsync<T>(this T bb, Func<Task> asyncAction) where T : ButtonBase
        //{
        //    bb.MouseLeftButtonDown += async (_, __) => await asyncAction ();

        //    return bb;
        //}

        //public static T OnTapped<T>(this T bb, Action<T> action) where T : ButtonBase
        //{
        //    bb.MouseLeftButtonDown += (_, __) => action (bb);
        //    return bb;
        //}

        //public static T OnTappedRelease<T>(this T bb, Action action) where T : ButtonBase
        //{
        //    bb.MouseLeftButtonUp += (_, __) => action ();
        //    return bb;
        //}
        //public static T OnTappedReleaseAsync<T>(this T bb, Func<Task> asyncAction) where T : ButtonBase
        //{
        //    bb.MouseLeftButtonUp += async (_, __) => await asyncAction ();

        //    return bb;
        //}
        //public static T OnTappedRelease<T>(this T bb, Action<T> action) where T : ButtonBase
        //{
        //    bb.MouseLeftButtonUp += (_, __) => action (bb);
        //    return bb;
        //}
    }
    public static class CommonElementExtentions
    {
        public static T OnTapped<T>(this T element, Action action) where T : UIElement
        {
            element.PreviewMouseDown += (_, __) => action ();

            return element;
        }
        public static T OnTappedAsync<T>(this T element, Func<Task> asyncAction) where T : UIElement
        {
            element.PreviewMouseDown += async (_, __) => await asyncAction ();

            return element;
        }
        public static T OnTapped<T>(this T element, MouseButtonEventHandler action) where T : UIElement
        {
            element.PreviewMouseDown += (sender, e) =>
            {
                action (sender, e);
                Mouse.Capture (element);
            };
            return element;
        }
        public static T OnTappedRelease<T>(this T element, Action action) where T : UIElement
        {
            element.PreviewMouseUp += (_, __) => action ();
            return element;
        }
        public static T OnTappedReleaseAsync<T>(this T element, Func<Task> asyncAction) where T : UIElement
        {
            element.PreviewMouseUp += async (_, __) => await asyncAction ();

            return element;
        }
        public static T OnTappedRelease<T>(this T element, MouseButtonEventHandler action) where T : UIElement
        {
            element.MouseUp += (sender, e) =>
            {
                if (e.ButtonState != MouseButtonState.Released)
                    return;
                if (Mouse.Captured == element)
                    Mouse.Capture (null); // 캡처 해제
                                          // ...기타 작업
                action (sender, e);
            };
            return element;
        }

        public static T OnHover<T>(this T element, Action action) where T : UIElement
        {
            element.MouseEnter += (_, __) => action ();
            return element;
        }
        public static T OnRelease<T>(this T element, Action action) where T : UIElement
        {
            element.MouseLeave += (_, __) => action ();
            return element;
        }
        public static T OnHover<T>(this T element, Action<T> action) where T : UIElement
        {
            element.MouseEnter += (_, __) => action (element);
            return element;
        }
        public static T OnRelease<T>(this T element, Action<T> action) where T : UIElement
        {
            element.MouseLeave += (_, __) => action (element);
            return element;
        }

        public static T OnChecked<T>(this T tb, Action action) where T : ToggleButton
        {
            tb.Checked += (_, __) => action ();
            return tb;
        }
        public static T OnCheckedAsync<T>(this T tb, Func<Task> asyncAction) where T : ToggleButton
        {
            tb.Checked += async (_, __) => await asyncAction ();
            return tb;
        }

        public static T OnUnchecked<T>(this T tb, Action action) where T : ToggleButton
        {
            tb.Unchecked += (_, __) => action ();
            return tb;
        }

        public static T OnIndeterminate<T>(this T tb, Action action) where T : ToggleButton
        {
            tb.Indeterminate += (_, __) => action ();
            return tb;

        }
        public static T OnChecked<T>(this T tb, Action<T> action) where T : ToggleButton
        {
            tb.Checked += (_, __) => action (tb);
            return tb;
        }

        public static T OnUnchecked<T>(this T tb, Action<T> action) where T : ToggleButton
        {
            tb.Unchecked += (_, __) => action (tb);
            return tb;
        }

        public static T OnIndeterminate<T>(this T tb, Action<T> action) where T : ToggleButton
        {
            tb.Indeterminate += (_, __) => action (tb);
            return tb;
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
        public static T OnTextChanged<T>(this T tb, Action action) where T : TextBox
        {
            tb.TextChanged += (_, __) => action ();

            return tb;
        }

        public static T OnTextChanged<T>(this T tb, TextChangedEventHandler action) where T : TextBox
        {
            tb.TextChanged += (_, __) => action (_, __);

            return tb;
        }
        public static T SelectionBrush<T>(this T tb, string color) where T : TextBox
        {
            tb.SelectionBrush (BrushTool.Get (color));
            return tb;
        }
        public static T SelectionBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.SelectionBrush (BrushTool.Get (color));
            return tb;
        }
        public static T SelectionBrush<T>(this T tb, Brush brush) where T : TextBox
        {
            tb.SelectionBrush = brush;
            return tb;
        }

        public static T SelectionTextBrush<T>(this T tb, string color) where T : TextBox
        {
            tb.SelectionTextBrush(BrushTool.Get (color));

            return tb;
        }
        public static T SelectionTextBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.SelectionTextBrush (BrushTool.Get (color));
            return tb;
        }

        public static T SelectionTextBrush<T>(this T tb, Brush brush) where T : TextBox
        {
            tb.SelectionTextBrush = brush;
            return tb;
        }

        public static T CaretBrush<T>(this T tb, string color) where T : TextBox
        {
            tb.CaretBrush (BrushTool.Get (color));

            return tb;
        }

        public static T CaretBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.CaretBrush (BrushTool.Get (color));
            return tb;
        }

        public static T CaretBrush<T>(this T tb, Brush brush) where T : TextBox
        {
            tb.CaretBrush = brush;
            return tb;
        }
    }

    
  
    public static class FlexCheckBoxExtentions
    {
        public static T CheckBoxColor<T>(this T fcb, Color color) where T : FlexCheckBox
        {
            return fcb.CheckBoxColor (BrushTool.Get (color));
        }
        public static T CheckBoxColor<T>(this T fcb, string color) where T : FlexCheckBox
        {
            return fcb.CheckBoxColor(BrushTool.Get (color));
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
            return fcb.CheckColor (BrushTool.Get (color));
        }
        public static T CheckColor<T>(this T fcb, string color) where T : FlexCheckBox
        {
            return fcb.CheckColor (BrushTool.Get (color));
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
            return fcb.CornerRadius (new CornerRadius (marginAll, marginAll, marginAll, marginAll));
        }

        public static T CornerRadius<T>(this T fcb, double leftright = 0, double topbottom = 0) where T : FlexCheckBox
        {
            return fcb.CornerRadius (new CornerRadius (leftright, topbottom, leftright, topbottom));
        }

        public static T CornerRadius<T>(this T fcb, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : FlexCheckBox
        {
            return fcb.CornerRadius(new CornerRadius (left, top, right, bottom));
        }

        public static T CornerRadius<T>(this T fcb, CornerRadius radius) where T : FlexCheckBox
        {
            fcb.SetValue(FlexCheckBox.CornerRadiusProperty, radius);
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
        public static T Orientation<T>(this T fp, Orientation orientation) where T : StackPanel
        {
            fp.Orientation = orientation;
            return fp;
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

        public static T Orientation<T>(this T fp, Orientation orientation) where T : FlexPanel
        {
            fp.Orientation = orientation;
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
