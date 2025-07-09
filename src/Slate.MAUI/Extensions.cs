namespace Slate.MAUI;

public  static class Extensions
{
    public static MauiAppBuilder UseSlate<T>(this MauiAppBuilder builder) where T : Bootstrapper
    {
        var bootstrapper = (Bootstrapper)Activator.CreateInstance(typeof(T));
        bootstrapper.Run ();
        return builder;
    }
}
