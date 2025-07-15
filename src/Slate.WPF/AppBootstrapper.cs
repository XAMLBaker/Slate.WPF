using DryIoc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace Slate.WPF
{
    public class AppBootstrapper : BootStrapperBase
    {
        public AppBootstrapper()
        {
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
            ViewModelInjector.SetContainer (container);

            Application.Current.MainWindow = (Window)container.Resolve (RegisterProvider.Window);
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
            Application.Current.MainWindow.Show ();
        }

        protected override void RegisterServices(IServiceCollection services)
        {
            Services.AddSingleton<IWindowManager, WindowManager> ();
            Services.AddSingleton<ILayoutNavigator, LayoutNavigator<FrameworkElement>> ();
            base.RegisterServices (services);
        }
    }
}
