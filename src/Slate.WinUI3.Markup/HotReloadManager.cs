using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Dispatching;
using System;
using System.Collections.Generic;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler (typeof (Slate.WinUI3.Markup.HotReloadManager))]

namespace Slate.WinUI3.Markup
{

    public static class HotReloadManager
    {
        public static Application app;
        public static void Init(Application application)
        {
            app = application;
        }
        public static void ClearCache(Type[]? types) { }
        public static void UpdateApplication(Type[]? types)
        {
            if (types is null)
                return;
            foreach (var type in types)
            {
                if (!typeof (IComponent).IsAssignableFrom (type))
                    continue;

                foreach (Window window in WindowManager.Windows)
                {
                    if (window.ToString ().Contains ("AdornerWindow"))
                        continue;

                    var dispatcherQueue = window.DispatcherQueue;
                    if (dispatcherQueue == null)
                        continue;

                    dispatcherQueue.TryEnqueue (() =>
                    {
                        if (window.Content is UIElement root)
                        {
                            foreach (var element in FindVisualChildren (root))
                            {
                                if (element == null)
                                    continue;

                                if (type.IsInstanceOfType (element) && element is IComponent comp)
                                {
                                    comp.Render ();
                                }
                            }
                        }
                    });
                }
            }
        }
        private static IEnumerable<DependencyObject> FindVisualChildren(DependencyObject parent)
        {
            if (parent == null)
                yield break;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount (parent); i++)
            {
                var child = VisualTreeHelper.GetChild (parent, i);
                if (child == null)
                    continue;

                yield return child;

                foreach (var grandChild in FindVisualChildren (child))
                {
                    yield return grandChild;
                }
            }
        }
    }
}
