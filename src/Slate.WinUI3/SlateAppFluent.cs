using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;

namespace Slate.WinUI3;

internal class SlateAppFluent : SlateFluent
{
    public SlateAppFluent()
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

        navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
    }
}
