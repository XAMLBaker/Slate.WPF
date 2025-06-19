using System.Windows.Input;
namespace MarkupChain.WPF
{
    public static class UIElementExtensions
    {
        public static T SetDock<T>(this T element, Dock dock) where T : UIElement
        {
            DockPanel.SetDock (element, dock);
            return element;
        }

        public static T Row<T>(this T element, int idx) where T : UIElement
        {
            Grid.SetRow (element, idx);
            return element;
        }

        public static T Column<T>(this T element, int idx) where T : UIElement
        {
            Grid.SetColumn (element, idx);
            return element;
        }

        public static T AllowDrop<T>(this T element, bool allowDrop) where T : UIElement
        {
            element.SetValue (UIElement.AllowDropProperty, allowDrop);
            return element;
        }
        public static T Opacity<T>(this T element, double opacity) where T : UIElement
        {
            element.SetValue (UIElement.OpacityProperty, opacity);
            return element;
        }

        public static T Visibility<T>(this T element, Visibility visibility) where T : UIElement
        {
            element.SetValue (UIElement.VisibilityProperty, visibility);
            return element;
        }

        public static T IsHitTestVisible<T>(this T element, bool isHitTestVisible) where T : UIElement
        {
            element.SetValue (UIElement.IsHitTestVisibleProperty, isHitTestVisible);
            return element;
        }


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
    }
}
