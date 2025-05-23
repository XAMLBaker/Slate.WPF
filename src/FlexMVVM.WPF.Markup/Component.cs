using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF.Markup
{
    public interface  IComponent
    {
        void Render();
    }
    [INotifyPropertyChanged]
    public abstract partial class BaseComponent : ContentControl, IComponent
    {
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
    }


    [INotifyPropertyChanged]
    public abstract partial class Component : ContentControl, IComponent
    {
        public Component()
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
        protected virtual void OnRender(object sender)
        {

        }

        public void Render()
        {
            this.Content = this.Build ();

            this.OnRender (this);
        }
        protected abstract Visual Build();
    }

    [INotifyPropertyChanged]
    public abstract partial class LayoutComponent : DockPanel, IComponent
    {
        public LayoutComponent()
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

        protected virtual void OnRender(object sender)
        {

        }
        public void Render()
        {
            List<UIElement> removeChildren = new List<UIElement> ();
            foreach (UIElement child in this.Children)
            {
                // DockPanel.Dock 의 설정 상태를 확인
                var valueSource = DependencyPropertyHelper.GetValueSource (child, DockPanel.DockProperty);

                // Local 값으로 설정되지 않은 경우
                if (valueSource.BaseValueSource.HasFlag (BaseValueSource.Local))
                {
                    removeChildren.Add (child);
                }
            }
            foreach (UIElement child in removeChildren)
            {
                this.Children.Remove(child);
            }

            var elements = this.Build ();
            int i = 0;
            foreach (var element in elements)
            {
                this.Children.Insert (i++,element);
            }
            this.OnRender (this);
        }
        protected abstract IEnumerable<UIElement> Build();
    }
}
