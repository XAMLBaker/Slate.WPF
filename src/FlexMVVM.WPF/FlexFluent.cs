using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using FlexMVVM.Modularity;
using FlexMVVM.Navigation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Windows;

namespace FlexMVVM.WPF
{
    public partial class FlexFluent
    {
        private FlexAppBuilder builder;
        private Register _register;

        public FlexFluent()
        {
            this.builder = FlexApp.CreateBuilder ();
            this.builder.Services.AddSingleton<ILayoutNavigator, LayoutNavigator> ();

            _register = new Register ();
            _register.RegisterMap["FlexFrameworkWindow"] = typeof (FlexWindow);
        }

        private IContainer CreateContainer()
        {
            builder.ModuleRegister ();
            foreach (var register in this._register.RegisterMap)
            {
                builder.Services.TryAddSingleton (register.Value);
            }
            var container = new Container ();
            container.WithDependencyInjectionAdapter (this.Services);

            foreach (var module in this.ModuleCatalog.GetModules())
            {
                module.Initialize (container);
            }
            container.BuildServiceProvider ();
            return container;
        }

        public void Run()
        {
            this.Init ();
            DependencyObject Shell = (DependencyObject)RegisterProvider.Window;
            if (Shell is Window window)
            {
                window.Show ();
            }
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            if (this._register.NestedLayout != null)
                navi.SetRootLayout ();

            navi.NavigateTo (this._register.InitialLayout.Namespace);
        }

        private void Init()
        {
            if (this._register.InitialLayout == null)
                throw new InvalidOperationException (
                    "초기 Layout이 설정되지 않았습니다. flex.StartWithLayout<T>()를 Render() 안에서 반드시 호출하세요."
                );

            RegisterProvider.SetRegister (this._register);
            IContainer container = this.CreateContainer ();
            RegisterProvider.SetContainer (container);
            RegisterProvider.SetServiceProvider (container.BuildServiceProvider());

            builder.ModuleInitialize (RegisterProvider.ServiceProvider);
        }

        public IModuleCatalog ModuleCatalog => this.builder.ModuleCatalog ();
        public IServiceCollection Services => this.builder.Services;
    }
}
