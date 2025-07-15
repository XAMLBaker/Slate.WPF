using DryIoc;
using System.Windows;
using System.Windows.Media;

namespace Slate.WPF
{
    public interface IWindowManager
    {

        IWindowManager SizeToContent(SizeToContent sizeToContent);
        IWindowManager Size(double width, double height);
        IWindowManager Background(Brush brush);

    }

    public class WindowManager : IWindowManager
    {
        private readonly IContainer _container;

        public WindowManager(IContainer container)
        {
            this._container = container;
        }
        public IWindowManager Background(Brush brush)
        {
            var window = (Window)this._container.Resolve(RegisterProvider.Window);

            window.Background = brush;
            return this;
        }

        public IWindowManager Size(double width, double height)
        {
            var window = (Window)this._container.Resolve (RegisterProvider.Window);

            window.Width = width;
            window.Height = height;

            return this;
        }

        public IWindowManager SizeToContent(SizeToContent sizeToContent)
        {
            var window = (Window)this._container.Resolve (RegisterProvider.Window);

            window.SizeToContent =sizeToContent;

            return this;
        }
    }
}
