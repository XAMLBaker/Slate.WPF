using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Slate.WPF
{
    internal class SlateAppFluent : SlateFluent
    {
        public SlateAppFluent()
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

            navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
            Application.Current.MainWindow.Show ();
        }
    }
}
