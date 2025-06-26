using Microsoft.UI.Xaml;
using System.Collections.Generic;

namespace Slate.WinUI3
{
    public static class WindowManager
    {
        private static readonly List<Window> _windows = new ();

        public static IReadOnlyList<Window> Windows => _windows.AsReadOnly ();

        public static void Register(Window window)
        {
            if (!_windows.Contains (window))
                _windows.Add (window);

            window.Closed += (s, e) => _windows.Remove (window);
        }
    }
}
