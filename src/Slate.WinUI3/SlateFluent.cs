using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;

namespace Slate.WinUI3;

internal class SlateFluent : Fluent
{
    public SlateFluent()
    {
        this.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<FrameworkElement>> ();
        RegisterProvider.SetWindow<SlateWindow> ();
    }

    public override void Run()
    {
        this.Init ();
        var main = (Window)RegisterProvider.Window;
        WindowManager.Register (main);
        main.Activate ();
        var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

        navi.NavigateToAsync (this._register.InitialLayout.Namespace);
    }
}
