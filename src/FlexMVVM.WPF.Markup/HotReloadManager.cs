
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

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
                    foreach (Type type in types)
                    {
                        if (type.GetInterfaces ().Any (x => x.Name == "IComponent"))
                        {
                            RenderAllOfType ((DependencyObject)((Window)window).Content, type);
                        }
                    }
                }
            });
        }
        private static void RenderAllOfType(DependencyObject root, Type targetType)
        {
            if (root == null)
                return;

            int count = VisualTreeHelper.GetChildrenCount (root);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild (root, i);

                if (child == null)
                    continue;

                // 원하는 타입이면 Render 호출
                if (targetType.IsInstanceOfType (child) && child is IComponent component)
                {
                    component.Render ();
                }

                // 재귀 탐색
                RenderAllOfType (child, targetType);
            }
        }
    }
}
