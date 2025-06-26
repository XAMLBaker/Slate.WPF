using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Windows;

namespace Slate.WPF
{
    public partial class SlateFluent
    {
        private SlateAppBuilder builder;
        private Register _register;
        private ViewModelMapper _viewModelMapper;
        public SlateFluent()
        {
            this.builder = SlateApp.CreateBuilder ();
            this.Services.AddSingleton<ILayoutNavigator, LayoutNavigator> ();
            this.Services.AddSingleton<IWindowManager, WindowManager> ();
            _viewModelMapper =new ViewModelMapper ();
            this.Services.AddSingleton<IViewModelMapper> (_viewModelMapper);

            _register = new Register ();
            _register.RegisterMap["SlateFrameworkWindow"] = typeof (SlateWindow);

            RegisterProvider.SetRegister (this._register);
        }

        private IContainer CreateContainer()
        {
            builder.ModuleRegister ();
            foreach (var register in this._register.RegisterMap)
            {
                this.Services.TryAddSingleton (register.Value);
            }
            var container = new Container ();
            container.WithDependencyInjectionAdapter (this.Services);

            foreach (var module in this.ModuleCatalog.GetModules())
            {
                module.Initialize (container);
            }
            foreach (var module in this.ModuleCatalog.GetModules ())
            {
                module.ViewModelMapper (_viewModelMapper);
            }
            container.BuildServiceProvider ();
            return container;
        }

        public void Run()
        {
            this.Init ();
            Application.Current.MainWindow = (Window)RegisterProvider.Window;
            Application.Current.MainWindow.Show ();
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            if (this._register.NestedLayout != null)
                navi.SetRootLayout ();

            navi.NavigateToAsync (this._register.InitialLayout.Namespace);
        }

        private void Init()
        {
            if (this._register.InitialLayout == null)
                throw new InvalidOperationException (
                    "초기 Layout이 설정되지 않았습니다. Slate.StartWithLayout<T>()를 Render() 안에서 반드시 호출하세요."
                );

            IContainer container = this.CreateContainer ();
            RegisterProvider.SetContainer (container);
            RegisterProvider.SetServiceProvider (container.BuildServiceProvider());
        }

        public IModuleCatalog ModuleCatalog => this.builder.ModuleCatalog ();
        public IServiceCollection Services => this.builder.Services;
        public IContainerRegistry ContainerRegistry => this.builder.ContainerRegistry;

        public IViewModelMapper ViewModelMapper => this._viewModelMapper;
    }
}
