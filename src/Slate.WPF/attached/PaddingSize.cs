using System;
using System.Windows;
using System.Windows.Controls;

namespace Slate.WPF
{
    public static class PaddingSize
    {
        public static readonly DependencyProperty ContentWidthProperty =
       DependencyProperty.RegisterAttached (
           "ContentWidth",
           typeof (double),
           typeof (PaddingSize),
           new FrameworkPropertyMetadata (0.0, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetContentWidth(UIElement element, double value) =>
            element.SetValue (ContentWidthProperty, value);

        public static double GetContentWidth(UIElement element) =>
            (double)element.GetValue (ContentWidthProperty);

        public static readonly DependencyProperty ContentHeightProperty =
            DependencyProperty.RegisterAttached (
                "ContentHeight",
                typeof (double),
                typeof (PaddingSize),
                new FrameworkPropertyMetadata (0.0, FrameworkPropertyMetadataOptions.Inherits));

        public static void SetContentHeight(UIElement element, double value) =>
            element.SetValue (ContentHeightProperty, value);

        public static double GetContentHeight(UIElement element) =>
            (double)element.GetValue (ContentHeightProperty);


        public static readonly DependencyProperty ContentSizeProperty =
            DependencyProperty.RegisterAttached (
                "ContentSize",
                typeof (Size),
                typeof (PaddingSize),
                new FrameworkPropertyMetadata (new Size (), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetContentSize(UIElement element, Size value) =>
            element.SetValue (ContentSizeProperty, value);

        public static Size GetContentSize(UIElement element) =>
            (Size)element.GetValue (ContentSizeProperty);

        public static readonly DependencyProperty TrackPaddingContentSizeProperty =
            DependencyProperty.RegisterAttached (
                "TrackPaddingContentSize",
                typeof (bool),
                typeof (PaddingSize),
                new PropertyMetadata (false, OnTrackPaddingContentSizeChanged));

        public static void SetTrackPaddingContentSize(UIElement element, bool value) =>
            element.SetValue (TrackPaddingContentSizeProperty, value);

        public static bool GetTrackPaddingContentSize(UIElement element) =>
            (bool)element.GetValue (TrackPaddingContentSizeProperty);

        private static void OnTrackPaddingContentSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FrameworkElement fe && e.NewValue is true)
            {
                fe.Loaded += (s, _) => UpdateSize (fe);
                fe.SizeChanged += (s, _) => UpdateSize (fe);
            }
        }

        private static void UpdateSize(FrameworkElement element)
        {
            Thickness padding = new Thickness ();
            if (element is Control control)
                padding = control.Padding;
            else if (element is Border border)
                padding = border.Padding;


            double width = Math.Max (0, element.ActualWidth - padding.Left - padding.Right);
            double height = Math.Max (0, element.ActualHeight - padding.Top - padding.Bottom);

            SetContentWidth (element, width);
            SetContentHeight (element, height);

            var contentSize = new Size (width, height);

            SetContentSize (element, contentSize);
        }
    }
}
