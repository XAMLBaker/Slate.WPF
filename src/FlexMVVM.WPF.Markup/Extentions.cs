using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
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
    public static class UIElementExtensions
    {
        public static T Width<T>(this T element, double value) where T : FrameworkElement
        {
            element.Width = value;
            return element;
        }

        public static T Height<T>(this T element, double value) where T : FrameworkElement
        {
            element.Height = value;
            return element;
        }

        public static T SetDock<T>(this T fe, Dock dock) where T : FrameworkElement
        {
            DockPanel.SetDock(fe, dock);
            return fe;
        }

        public static T Row<T>(this T fe, int idx) where T : FrameworkElement
        {
            Grid.SetRow(fe, idx);
            return fe;
        }

        public static T Column<T>(this T fe, int idx) where T : FrameworkElement
        {
            Grid.SetColumn (fe, idx);
            return fe;
        }
        public static T Margin<T>(this T fe, double marginAll = 0) where T : FrameworkElement
        {
            fe.Margin = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return fe;
        }
        public static T Margin<T>(this T fe, double leftright = 0, double topbottom = 0) where T : FrameworkElement
        {
            fe.Margin = new Thickness (leftright, topbottom, leftright, topbottom);
            return fe;
        }
        public static T Margin<T>(this T fe, double left = 0, double top =0, double right =0, double bottom =0) where T : FrameworkElement
        {
            fe.Margin = new Thickness(left,top,right,bottom);
            return fe;
        }
        public static T Center<T>(this T fe) where T : FrameworkElement
        {
            fe.VerticalAlignment = VerticalAlignment.Center;
            fe.HorizontalAlignment = HorizontalAlignment.Center;
            return fe;
        }
        public static T VCenter<T>(this T fe) where T : FrameworkElement
        {
            fe.VerticalAlignment = VerticalAlignment.Center;
            return fe;
        }
        public static T HCenter<T>(this T fe) where T : FrameworkElement
        {
            fe.HorizontalAlignment = HorizontalAlignment.Center;
            return fe;
        }
        public static T Left<T>(this T fe) where T : FrameworkElement
        {
            fe.HorizontalAlignment = HorizontalAlignment.Left;
            return fe;
        }
        public static T Right<T>(this T fe) where T : FrameworkElement
        {
            fe.HorizontalAlignment = HorizontalAlignment.Right;
            return fe;
        }
        public static T Top<T>(this T fe) where T : FrameworkElement
        {
            fe.VerticalAlignment = VerticalAlignment.Top;
            return fe;
        }
        public static T Bottom<T>(this T fe) where T : FrameworkElement
        {
            fe.VerticalAlignment = VerticalAlignment.Bottom;
            return fe;
        }
        
        public static T MinWidth<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.MinWidth = value;
            return fe;
        }
        public static T MaxWidth<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.MaxWidth = value;
            return fe;
        }
        public static T MinHeight<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.MinHeight = value;
            return fe;
        }
        public static T MaxHeight<T>(this T fe, double value) where T : FrameworkElement
        {
            fe.MaxHeight = value;
            return fe;
        }
        public static T Tag<T>(this T fe, object value) where T : FrameworkElement
        {
            fe.Tag = value;
            return fe;
        }

        public static T UseLayoutRounding<T>(this T fe) where T : FrameworkElement
        {
            fe.UseLayoutRounding = true;
            return fe;
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
        public static T OnHover<T>(this T element, Action<T> action) where T : TextBox
        {
            element.MouseEnter += (_, __) => action (element);
            return element;
        }
        public static T OnRelease<T>(this T element, Action<T> action) where T : TextBox
        {
            element.MouseLeave += (_, __) => action (element);
            return element;
        }
        public static T OnPreviewText<T>(this T tb, Action action) where T : TextBox
        {
            tb.PreviewTextInput += (_, __) => action ();

            return tb;
        }
        public static T BorderThickness<T>(this T tb, double marginAll = 0) where T : TextBox
        {
            tb.BorderThickness = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return tb;
        }
        public static T BorderThickness<T>(this T tb, double leftright = 0, double topbottom = 0) where T : TextBox
        {
            tb.BorderThickness = new Thickness (leftright, topbottom, leftright, topbottom);
            return tb;
        }
        public static T BorderThickness<T>(this T tb, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : TextBox
        {
            tb.BorderThickness = new Thickness (left, top, right, bottom);

            return tb;
        }
        public static T BorderBrush<T>(this T tb, string colorString) where T : TextBox
        {
            tb.BorderBrush = new SolidColorBrush (ColorTool.Get (colorString));

            return tb;
        }
        public static T BorderBrush<T>(this T tb, Color color) where T : TextBox
        {
            tb.BorderBrush = new SolidColorBrush (color);
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

        public static T Fontsize<T>(this T ctrl, double size) where T : Control
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
    public static class PathExtentions
    {
        // 봉인 클래스라서 확장이안된다네 ..ㅠ
        //public static T Data<T>(this T path, string pathData) where T : Path
        //{
        //    Geometry geometry = Geometry.Parse (pathData);
        //    path.Data = geometry;
        //    return path;
        //}

        public static Geometry Data(string pathData)
        {
            return Geometry.Parse (pathData);
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
    }
}
