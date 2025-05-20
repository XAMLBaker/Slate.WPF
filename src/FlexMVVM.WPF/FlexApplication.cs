using FlexMVVM.Modularity;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace FlexMVVM.WPF
{
    public abstract class FlexApplication : Application
    {
        protected FlexFluent flex;

        protected FlexApplication()
        {
            this.flex = new FlexFluent ();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup (e);
            
            this.Render ();

            this.ModuleContext (this.flex.ModuleCatalog);
            this.RegisterService (this.flex.Services);

            OnInitialized ();
        }

        protected abstract void Render();
        protected virtual void ModuleContext(IModuleCatalog moduleCatalog){}
        protected virtual void RegisterService(IServiceCollection services){}

        protected virtual void OnInitialized()
        {
            flex.Run ();
        }
    }
}
