using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Slate.Avalonia
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
            _viewModelMapper =new ViewModelMapper ();
            this.Services.AddSingleton<IViewModelMapper> (_viewModelMapper);

            _register = new Register ();

            RegisterProvider.SetRegister (this._register);
        }

        private IContainer CreateContainer()
        {
            builder.ModuleRegister ();
            foreach (var register in this._register.RegisterMap)
            {
                this.Services.TryAddSingleton (register.Value);
            }
            IContainer container = new Container ();
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

        public void Run(Application app)
        {
            this.Init ();
            if (app.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = (Window)RegisterProvider.Window;
            }
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            if (this._register.NestedLayout != null)
                navi.SetRootLayout ();

            navi.NavigateToAsync (this._register.InitialLayout.Namespace);
        }

        private void Init()
        {
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
