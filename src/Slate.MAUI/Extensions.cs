namespace Slate.MAUI;

public  static class Extensions
{
    public static MauiAppBuilder UseSlate<T>(this MauiAppBuilder builder) where T : AppBootstrapper
    {
        var bootstrapper = (AppBootstrapper)Activator.CreateInstance(typeof(T));
        bootstrapper.Run ();
        return builder;
    }
}
