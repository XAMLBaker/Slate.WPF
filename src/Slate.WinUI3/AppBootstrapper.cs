using DryIoc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml;
using System;

namespace Slate.WinUI3
{
    public class AppBootstrapper : BootStrapperBase
    {
        public AppBootstrapper() {

            this._containerRegistry.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<FrameworkElement>> ();
            RegisterProvider.SetWindow<SlateWindow> ();
        }
        public AppBootstrapper Window<T>()
        {
            _register.RegisterMap["SlateFrameworkWindow"] = typeof (T);

            return this;
        }

        public override void Run()
        {
            if (this._register.InitialLayout == null)
                throw new InvalidOperationException (
                    "초기 Layout이 설정되지 않았습니다. Slate.StartLayout<T>()를 Render() 안에서 반드시 호출하세요."
                );

            Load ();

            IContainer container = this.CreateContainer ();
            RegisterProvider.SetContainer (container);

            var main = (Window)container.Resolve (RegisterProvider.Window);
            WindowManager.Register (main);
            main.Activate ();
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
        }
    }
}
