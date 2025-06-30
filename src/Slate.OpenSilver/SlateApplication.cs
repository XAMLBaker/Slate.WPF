
namespace Slate.OpenSilver
{
    public abstract class SlateApplication : System.Windows.Application
    {
        protected SlateFluent Slate;

        protected SlateApplication()
        {
            this.Slate = new SlateFluent ();
        }

        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            base.OnStartup (e);
            
            this.Render ();

            this.ModuleContext (this.Slate.ModuleCatalog);
            this.Register (this.Slate.ContainerRegistry);
            this.ViewModelMapper (this.Slate.ViewModelMapper);

            OnInitialized ();
        }

        protected abstract void Render();
        protected virtual void ModuleContext(IModuleCatalog moduleCatalog){}
        protected virtual void Register(IContainerRegistry containerRegistry) {}

        protected virtual void ViewModelMapper(IViewModelMapper modelMapper){}

        protected virtual void OnInitialized()
        {
            Slate.Run ();
        }
    }
}
