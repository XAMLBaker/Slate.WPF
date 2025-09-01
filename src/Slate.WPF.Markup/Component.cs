namespace Slate.WPF.Markup
{
    public interface IComponent
    {
        void Render();
    }
    [INotifyPropertyChanged]
    public abstract partial class BaseComponent : ContentControl, IComponent, IShellComponent
    {
        static BaseComponent()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (BaseComponent), new FrameworkPropertyMetadata (typeof (BaseComponent)));
        }
        public BaseComponent()
        {
            this.DataContext = this;
            this.Loaded += this.OnLoaded;
            if (this.ComponentStyleKey != null)
                this.SetResourceReference (StyleProperty, this.ComponentStyleKey);
        }

        public object? ComponentStyleKey { get; set; }

        protected virtual void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.Render ();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized (e);
        }

        public abstract void Render();

        public virtual void RegionAttached(object argu)
        {

        }
    }


    [INotifyPropertyChanged]
    public abstract partial class Component : ContentControl, IComponent, IShellComponent
    {
        static Component()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (Component), new FrameworkPropertyMetadata (typeof (Component)));
        }
        public object? ComponentStyleKey { get; set; }

        protected virtual void OnLoaded(object sender, RoutedEventArgs e)
        {

        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized (e);

            this.DataContext = this;
            this.Loaded += this.OnLoaded;
            this.Render ();
            if (this.ComponentStyleKey != null)
                this.SetResourceReference (StyleProperty, this.ComponentStyleKey);
        }

        protected virtual void OnRender(object sender)
        {

        }

        public void Render()
        {
            this.InitilzedForms ();
            UIElement visual = this.Build ();
            if (visual != null)
            {
                this.Content = visual;
            }

            this.OnRender (this);
        }
        protected virtual void InitilzedForms()
        {

        }
        protected abstract UIElement Build();

        public virtual void RegionAttached(object argu)
        {

        }
        protected void RegionSet(string regionName)
        {
            RegionManager.Attach (regionName, this);
        }
    }
}
