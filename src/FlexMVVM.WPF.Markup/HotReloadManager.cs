using DryIoc;
using System.Collections;
using System.Linq;
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

                    foreach (Type type in types)
                    {
                        if (type.GetInterfaces ().Any (x => x.Name == "IComponent"))
                        {
                            var temp = RegisterProvider.Container.Resolve (type);
                            ((IComponent)temp).Render ();
                        }
                    }
                }
            });
        }
    }
}
