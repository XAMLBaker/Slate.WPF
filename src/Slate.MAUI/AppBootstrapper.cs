namespace Slate.MAUI
{
    public class AppBootstrapper : BootStrapperBase
    {
        public Action<IServiceProvider>? InitializeAction { get; set; }
        public Action<IViewModelMapper>? ViewModelRegisterAction { get; set; }
        protected IServiceProvider ServiceProvider { get; private set; }

        public AppBootstrapper()
        {

        }

        protected override void ViewModelMapper(IViewModelMapper modelMapper)
        {
            ViewModelRegisterAction?.Invoke (modelMapper);
        }
        protected virtual void Initialize(IServiceProvider serviceProvider)
        {
            InitializeAction?.Invoke (serviceProvider);
        }

        internal void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<ILayoutNavigator, LayoutNavigator<View>> ();

            // 모듈의 ConfigureServices 호출
            foreach (var module in this._moduleCatalog.GetModules ())
            {
                module.Register (services);
            }

            this.Register (services);
        }
    }
}
