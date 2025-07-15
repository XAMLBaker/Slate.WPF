using DryIoc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace Slate.OpenSilver
{
    public class AppBootstrapper : BootStrapperBase
    {
        public AppBootstrapper()
        {
            this._containerRegistry.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<FrameworkElement>> ();
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

            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
        }
    }
}
