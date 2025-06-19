[assembly: System.Reflection.Metadata.MetadataUpdateHandler (typeof (Slate.WPF.Markup.HotReloadManager))]

namespace Slate.WPF.Markup
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
            app?.Dispatcher.Invoke (() =>
            {
                if (types is null)
                    return;
                foreach (var type in types)
                {
                    if (!typeof (IComponent).IsAssignableFrom (type))
                        continue;

                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window.ToString ().Contains ("AdornerWindow"))
                            continue;

                        var root = (DependencyObject)window.Content;

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
                }
            });
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
