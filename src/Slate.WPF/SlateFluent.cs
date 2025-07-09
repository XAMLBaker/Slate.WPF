using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Slate.WPF
{
    internal class SlateFluent : Fluent
    {
        public SlateFluent()
        {
            this.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<FrameworkElement>> ();
            this.Services.AddSingleton<IWindowManager, WindowManager> ();

            RegisterProvider.SetWindow<SlateWindow> ();
        }

        public override void Run()
        {
            this.Init ();
            Application.Current.MainWindow = (Window)RegisterProvider.Window;
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (this._register.InitialLayout.Namespace);
            Application.Current.MainWindow.Show ();
        }
    }
}
