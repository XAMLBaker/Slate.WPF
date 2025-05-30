using DryIoc;
using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public interface ILayoutManager
    {
        ILayoutManager Left<T>() where T : FrameworkElement;
        ILayoutManager Right<T>() where T : FrameworkElement;
        ILayoutManager Top<T>() where T : FrameworkElement;
        ILayoutManager Bottom<T>() where T : FrameworkElement;
        ILayoutManager Content<T>() where T : FrameworkElement;
        ILayoutManager DataContext<T>() where T : class;
    }

    public class LayoutManager : DockPanel, ILayoutManager
    {
        private readonly IContainer _container;
        private DockPanel dock;
        private ContentControl left;
        private ContentControl right;
        private ContentControl top;
        private ContentControl bottom;
        private ContentControl content;
        public LayoutManager(IContainer container)
        {
            this._container = container;
            dock = new ();

            left = new ContentControl (); 
            right = new ContentControl (); 
            top = new ContentControl (); 
            bottom = new ContentControl ();
            content = new ContentControl ();
            DockPanel.SetDock (left, Dock.Left);
            DockPanel.SetDock (right, Dock.Right);
            DockPanel.SetDock (top, Dock.Top);
            DockPanel.SetDock (bottom, Dock.Bottom);
        }

        public ILayoutManager Bottom<T>() where T : FrameworkElement
        {
            var element = this._container.Resolve<T> ();

            bottom.Content = element;
            dock.Children.Add (bottom);

            return this;
        }

        public ILayoutManager Content<T>() where T : FrameworkElement
        {
            var element = this._container.Resolve<T> ();

            content.Content = element;
            dock.Children.Add (content);

            return this;
        }

        public ILayoutManager DataContext<T>() where T : class
        {
            var element = this._container.Resolve<T> ();

            this.dock.DataContext = element;
            return this;
        }

        public ILayoutManager Left<T>() where T : FrameworkElement
        {
            var element = this._container.Resolve<T> ();

            left.Content = element;
            dock.Children.Add (left);

            return this;
        }

        public ILayoutManager Right<T>() where T : FrameworkElement
        {
            var element = this._container.Resolve<T> ();

            right.Content = element;
            dock.Children.Add (right);

            return this;
        }

        public ILayoutManager Top<T>() where T : FrameworkElement
        {
            var element = this._container.Resolve<T> ();

            top.Content = element;
            dock.Children.Add (top);

            return this;
        }
    }
}