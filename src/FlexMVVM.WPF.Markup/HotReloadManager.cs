using System.Collections;
using System.Reflection;
using System.Windows;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler (typeof (FlexMVVM.WPF.Markup.HotReloadManager))]

namespace FlexMVVM.WPF.Markup
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
                foreach (var window in Application.Current.Windows)
                {
                    if (window.ToString () == "Microsoft.VisualStudio.DesignTools.WpfTap.WpfVisualTreeService.Adorners.AdornerWindow")
                    {
                        continue;
                    }
                    var content = (DependencyObject)((Window)window).Content;

                    if (content != null && content is IComponent c && types.Any(x=>x.GetInterfaces().Any(y=>y.Name == "IComponent")))
                    {
                        c.Render ();
                    }
                }
            });
        }
    }
}
