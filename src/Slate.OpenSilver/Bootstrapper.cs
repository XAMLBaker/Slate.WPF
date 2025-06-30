using System.Windows;

namespace Slate.OpenSilver
{
    public class Bootstrapper
    {
        protected SlateFluent Slate;
        public Bootstrapper() {
            this.Slate = new SlateFluent ();
        }

        public Bootstrapper StartLayout<T>()
        {
            this.Slate.StartWithLayout<T> ();
            return this;
        }

        protected virtual void Register(IContainerRegistry containerRegistry) { }

        protected virtual void ModuleContext(IModuleCatalog moduleCatalog) { }
        protected virtual void ViewModelMapper(IViewModelMapper modelMapper) { }

        public void Run()
        {
            this.ModuleContext (this.Slate.ModuleCatalog);
            this.Register (this.Slate.ContainerRegistry);
            this.ViewModelMapper (this.Slate.ViewModelMapper);
            Slate.Run ();
        }
    }
}
