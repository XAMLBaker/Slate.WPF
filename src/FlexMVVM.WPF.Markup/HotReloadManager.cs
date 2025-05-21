
using System;
using System.Linq;
using System.Windows;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler  (typeof (FlexMVVM.WPF.Markup.HotReloadManager))]

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
                foreach (var component in ComponentHost.GetActiveComponents ())
                {
                    var componentType = component.GetType ();

                    // 변경된 타입 목록 중에 일치하는 것이 있는 경우만 Build()
                    if (types.Any (t => t == componentType))
                    {
                        component.Render ();
                    }
                }
            });
        }
    }
}
