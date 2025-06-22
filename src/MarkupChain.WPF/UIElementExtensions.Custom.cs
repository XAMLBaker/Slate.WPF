using System.Windows.Input;
namespace MarkupChain.WPF
{
    public static partial class UIElementExtensions
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

        public static T RowSpan<T>(this T element, int value) where T : UIElement
        {
            Grid.SetRowSpan (element, value);
            return element;
        }

        public static T Column<T>(this T element, int idx) where T : UIElement
        {
            Grid.SetColumn (element, idx);
            return element;
        }

        public static T ColumnSpan<T>(this T element, int value) where T : UIElement
        {
            Grid.SetColumnSpan (element, value);
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
