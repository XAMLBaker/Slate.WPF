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
            this.Register (this.flex.ContainerRegistry);

            OnInitialized ();
        }

        protected abstract void Render();
        protected virtual void ModuleContext(IModuleCatalog moduleCatalog){}
        protected virtual void Register(IContainerRegistry containerRegistry) {}

        protected virtual void OnInitialized()
        {
            flex.Run ();
        }
    }
}
