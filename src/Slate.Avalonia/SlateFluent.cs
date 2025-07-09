using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Microsoft.Extensions.DependencyInjection;

namespace Slate.Avalonia
{
    internal class SlateFluent : Fluent
    {
        Application _app;
        public SlateFluent(Application app)
        {
            this._app = app;
            this.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<Control>> ();

            RegisterProvider.SetWindow<SlateWindow> ();
        }

        public override void Run()
        {
            this.Init ();
            if (_app.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = (Window)RegisterProvider.Window;
            }
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (this._register.InitialLayout.Namespace);
        }
    }
}
