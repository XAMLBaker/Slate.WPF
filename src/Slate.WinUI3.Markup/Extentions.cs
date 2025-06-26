namespace Slate.WinUI3.Markup
{
    public static class Extentions
    {
        public static T UseMarkupHotReload<T>(this T bootstrapper, Application application)
        {
            HotReloadManager.Init (application);

            return bootstrapper;
        }
    }
}
