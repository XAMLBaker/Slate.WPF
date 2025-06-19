using System.Windows.Controls.Primitives;

namespace MarkupChain.WPF
{
    public static class ToggleButtonExtensions
    {
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
}
