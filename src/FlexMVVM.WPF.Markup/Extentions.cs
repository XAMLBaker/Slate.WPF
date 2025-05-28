using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
    public static class ControlExtentions
    {
        public static T Background<T>(this T ctrl, string colorString) where T : Control
        {
            ctrl.Background(ColorTool.Get (colorString));

            return ctrl;
        }
        public static T Background<T>(this T pnl, Color color) where T : Control
        {
            pnl.Background = new SolidColorBrush (color);

            return pnl;
        }
        public static T Foreground<T>(this T ctrl, string colorString) where T : Control
        {
            ctrl.Foreground(ColorTool.Get (colorString));

            return ctrl;
        }
        public static T Foreground<T>(this T ctrl, Color color) where T : Control
        {
            ctrl.Foreground = new SolidColorBrush (color);

            return ctrl;
        }

        public static T FontSize<T>(this T ctrl, double size) where T : Control
        {
            ctrl.FontSize = size;

            return ctrl;
        }

        public static T FontFamliy<T>(this T ctrl, double fontFamliy) where T : Control
        {
            ctrl.FontSize = fontFamliy;

            return ctrl;
        }
        public static T FontWeight<T>(this T ctrl, FontWeight size) where T : Control
        {
            ctrl.FontWeight = size;

            return ctrl;
        }
        public static T FontStyle<T>(this T ctrl, FontStyle style) where T : Control
        {

            ctrl.FontStyle = style;

            return ctrl;
        }
        public static T FontStretch<T>(this T ctrl, FontStretch stretch) where T : Control
        {
            ctrl.FontStretch = stretch;

            return ctrl;
        }
        public static T BorderBrush<T>(this T tb, string colorString) where T : Control
        {
            tb.BorderBrush = new SolidColorBrush (ColorTool.Get (colorString));

            return tb;
        }
        public static T BorderBrush<T>(this T tb, Color color) where T : Control
        {
            tb.BorderBrush = new SolidColorBrush (color);
            return tb;
        }
        public static T BorderThickness<T>(this T tb, double marginAll = 0) where T : Control
        {
            tb.BorderThickness = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return tb;
        }
        public static T BorderThickness<T>(this T tb, double leftright = 0, double topbottom = 0) where T : Control
        {
            tb.BorderThickness = new Thickness (leftright, topbottom, leftright, topbottom);
            return tb;
        }
        public static T BorderThickness<T>(this T tb, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
        {
            tb.BorderThickness = new Thickness (left, top, right, bottom);

            return tb;
        }
        public static T BorderThickness<T>(this T tb, Thickness value) where T : Control
        {
            if (value == null)
                return tb;
            tb.BorderThickness = value;

            return tb;
        }
        public static T Padding<T>(this T bdr, double marginAll = 0) where T : Control
        {
            bdr.Padding = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return bdr;
        }
        public static T Padding<T>(this T bdr, double leftright = 0, double topbottom = 0) where T : Control
        {
            bdr.Padding = new Thickness (leftright, topbottom, leftright, topbottom);
            return bdr;
        }
        public static T Padding<T>(this T bdr, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
        {
            bdr.Padding = new Thickness (left, top, right, bottom);
            return bdr;
        }
        public static T Padding<T>(this T bdr, Thickness thickness) where T : Control
        {
            if (thickness == null)
                return bdr;
            bdr.Padding = thickness;
            return bdr;
        }
    }

    public static class ContentControlExtentions
    {
        public static T Content<T>(this T ctrl, object content) where T : ContentControl
        {
            ctrl.Content = content;

            return ctrl;
        }       
    }

    public static class ImageExtentions
    {
        public static T Source<T>(this T image, string Source) where T : Image
        {
            image.Source = SetImageSource(Source);
            return image;
        }

        public static T Stretch<T>(this T image, Stretch stretch) where T : Image
        {
            image.Stretch = stretch;
            return image;
        }

        private static BitmapImage SetImageSource(string packUri)
        {
            try
            {
                Uri imageUri;
                imageUri = new Uri (packUri, UriKind.RelativeOrAbsolute);

                // BitmapImage로 설정
                var bitmap = new BitmapImage ();
                bitmap.BeginInit ();
                bitmap.UriSource = imageUri;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit ();
                bitmap.Freeze ();
                return bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"이미지를 로드하는 중 오류가 발생했습니다: {ex.Message}");
            }

            return null;
        }
    }

    public static class PanelExtentions
    {
        public static T Children<T>(this T panel, params UIElement[] elements) where T : Panel
        {
            foreach (var element in elements)
            {
                panel.Children.Add (element);
            }
            return panel;
        }
        public static T Background<T>(this T pnl, string colorString) where T : Panel
        {
            pnl.Background = BrushTool.Get (colorString);

            return pnl;
        }
        public static T Background<T>(this T pnl, Color color) where T : Panel
        {
            pnl.Background = new SolidColorBrush (color);

            return pnl;
        }
    }

    public static class UniformExtentions
    {
        public static T Columns<T>(this T panel, int columnCount) where T : UniformGrid
        {
            panel.Columns = columnCount;
            return panel;
        }
        public static T Rows<T>(this T panel, int columnCount) where T : UniformGrid
        {
            panel.Rows = columnCount;
            return panel;
        }

        public static T FirstColumn<T>(this T panel, int startColumnIndex) where T : UniformGrid
        {
            panel.FirstColumn = startColumnIndex;
            return panel;
        }
    }

    public static class DecoratorExtnetions
    {
        public static T Child<T>(this T fe, UIElement element) where T : Decorator
        {
            fe.Child = element;
            return fe;
        }
    }

    public static class BorderExtentions
    {
        public static T Background<T>(this T bdr, string colorString) where T : Border
        {
            bdr.Background = BrushTool.Get (colorString);

            return bdr;
        }
        public static T Background<T>(this T bdr, Color color) where T : Border
        {
            bdr.Background = new SolidColorBrush (color);

            return bdr;
        }

        public static T Padding<T>(this T bdr, double marginAll = 0) where T : Border
        {
            bdr.Padding = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return bdr;
        }
        public static T Padding<T>(this T bdr, double leftright = 0, double topbottom = 0) where T : Border
        {
            bdr.Padding = new Thickness (leftright, topbottom, leftright, topbottom);
            return bdr;
        }
        public static T Padding<T>(this T bdr, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Border
        {
            bdr.Padding = new Thickness (left, top, right, bottom);
            return bdr;
        }
        public static T CornerRadius<T>(this T bdr, double marginAll = 0) where T : Border
        {
            bdr.CornerRadius = new CornerRadius (marginAll, marginAll, marginAll, marginAll);
            return bdr;
        }
        public static T CornerRadius<T>(this T bdr, double leftright = 0, double topbottom = 0) where T : Border
        {
            bdr.CornerRadius = new CornerRadius (leftright, topbottom, leftright, topbottom);
            return bdr;
        }
        public static T CornerRadius<T>(this T bdr, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Border
        {
            bdr.CornerRadius = new CornerRadius (left, top, right, bottom);
            return bdr;
        }

        public static T Brush<T>(this T bdr, string colorString) where T : Border
        {
            bdr.BorderBrush = new SolidColorBrush (ColorTool.Get (colorString));

            return bdr;
        }
        public static T Brush<T>(this T bdr, Color color) where T : Border
        {
            bdr.BorderBrush = new SolidColorBrush (color);

            return bdr;
        }
        public static T Thickness<T>(this T bdr, double marginAll = 0) where T : Border
        {
            bdr.BorderThickness = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return bdr;
        }
        public static T Thickness<T>(this T bdr, double leftright = 0, double topbottom = 0) where T : Border
        {
            bdr.BorderThickness = new Thickness (leftright, topbottom, leftright, topbottom);
            return bdr;
        }
        public static T Thickness<T>(this T bdr, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Border
        {
            bdr.BorderThickness = new Thickness (left, top, right, bottom);

            return bdr;
        }
    }
    public static class ShapeExtentions
    {
        public static T Fill<T>(this T shape, string colorString) where T : Shape
        {
            shape.Fill = BrushTool.Get (colorString);

            return shape;
        }

        public static T Fill<T>(this T shape, Color color) where T : Shape
        {
            shape.Fill = new SolidColorBrush (color);

            return shape;

        }
        public static T Brush<T>(this T shape, string colorString) where T : Shape
        {
            shape.Stroke = BrushTool.Get (colorString);

            return shape;
        }

        public static T Brush<T>(this T shape, Color color) where T : Shape
        {
            shape.Stroke = new SolidColorBrush (color);

            return shape;
        }

        public static T DashArray<T>(this T shape, DoubleCollection strokeDashArray) where T : Shape
        {
            shape.StrokeDashArray = strokeDashArray;

            return shape;
        }
        public static T MiterLimit<T>(this T shape, double strokeMiterLimit) where T : Shape
        {
            shape.StrokeMiterLimit = strokeMiterLimit;

            return shape;
        }

        public static T LineJoin<T>(this T shape, PenLineJoin penLineJoin) where T : Shape
        {
            shape.StrokeLineJoin = penLineJoin;

            return shape;
        }
        public static T DashCap<T>(this T shape, PenLineCap strokeDashCap) where T : Shape
        {
            shape.StrokeDashCap = strokeDashCap;

            return shape;
        }
        public static T LineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeStartLineCap = lineCap;
            shape.StrokeEndLineCap = lineCap;

            return shape;
        }

        public static T StartLineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeStartLineCap = lineCap;

            return shape;
        }

        public static T EndLineCap<T>(this T shape, PenLineCap lineCap) where T : Shape
        {
            shape.StrokeEndLineCap = lineCap;

            return shape;
        }

        public static T Thickness<T>(this T shape, double marginAll = 0) where T : Shape
        {
            shape.StrokeThickness = marginAll;

            return shape;
        }
    }
    

    public static class FlexTextBoxExtentions
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

        public static T HoverBrush<T>(this T ftb, string colorString) where T : FlexTextBox
        {
            ftb.HoverBrush = BrushTool.Get (colorString);

            return ftb;
        }

        public static T HoverBrush<T>(this T ftb, Color color) where T : FlexTextBox
        {
            ftb.HoverBrush = new SolidColorBrush (color);

            return ftb;
        }

        public static T CornerRadius<T>(this T ftb, double marginAll = 0) where T : FlexTextBox
        {
            ftb.CornerRadius = new CornerRadius (marginAll, marginAll, marginAll, marginAll);
            return ftb;
        }
        public static T CornerRadius<T>(this T ftb, double leftright = 0, double topbottom = 0) where T : FlexTextBox
        {
            ftb.CornerRadius = new CornerRadius (leftright, topbottom, leftright, topbottom);
            return ftb;
        }
        public static T CornerRadius<T>(this T ftb, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : FlexTextBox
        {
            ftb.CornerRadius = new CornerRadius (left, top, right, bottom);

            return ftb;
        }
        public static T BorderBrush<T>(this T tb, string baseColor, string hoverColor) where T : FlexTextBox
        {
            tb.BorderBrush (baseColor);
            tb.HoverBrush(hoverColor);

            return tb;
        }
        public static T BorderBrush<T>(this T tb, string baseColor, Color hoverColor) where T : FlexTextBox
        {
            tb.BorderBrush (baseColor);
            tb.HoverBrush (hoverColor);

            return tb;
        }
        public static T BorderBrush<T>(this T tb, Color baseColor, string hoverColor) where T : FlexTextBox
        {
            tb.BorderBrush (baseColor);
            tb.HoverBrush (hoverColor);

            return tb;
        }
        public static T BorderBrush<T>(this T tb, Color baseColor, Color hoverColor) where T : FlexTextBox
        {
            tb.BorderBrush (baseColor);
            tb.HoverBrush (hoverColor);

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
}
