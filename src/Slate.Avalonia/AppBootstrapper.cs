using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using DryIoc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Slate.Avalonia
{
    public class AppBootstrapper : BootStrapperBase
    {
        Application _app;
        public AppBootstrapper(Application application) {

            this._app = application;

            RegisterProvider.SetWindow<SlateWindow> ();
            Services = new ServiceCollection ();
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

            RegisterServices (Services);

            ViewModelMapperLoad ();

            IContainer container = this.CreateContainer ();
            RegisterProvider.SetContainer (container);
            if (_app.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = (Window)container.Resolve(RegisterProvider.Window);
            }
            var navi = container.Resolve<ILayoutNavigator> ();

            navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
        }

        protected override void RegisterServices(IServiceCollection services)
        {
            Services.AddSingleton<ILayoutNavigator, LayoutNavigator<Control>> ();
            base.RegisterServices (services);
        }
    }
}
