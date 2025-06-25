using DryIoc;
using System;
using System.Windows;
using System.Windows.Shell;

namespace Slate.WPF
{
    public interface IWindowManager
    {
        IWindowManager CornerRadius(double all);
        IWindowManager CornerRadius(double leftRight, double topBottom);
        IWindowManager CornerRadius(double left= 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0);

        IWindowManager SizeToContent(SizeToContent sizeToContent);
        IWindowManager Size(double width, double height);
    }

    public class WindowManager : IWindowManager
    {
        private readonly IContainer _container;

        public WindowManager(IContainer container)
        {
            this._container = container;
        }
        public IWindowManager CornerRadius(double all)
        {
            CornerRadius (new CornerRadius (all));

            return this;
        }

        public IWindowManager CornerRadius(double leftRight, double topBottom)
        {
            CornerRadius (new CornerRadius (leftRight, topBottom, leftRight, topBottom));

            return this;
        }

        public IWindowManager CornerRadius(double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0)
        {
            CornerRadius (new CornerRadius (left, top, right, bottom));

            return this;
        }

        public IWindowManager Size(double width, double height)
        {
            Type winType = RegisterProvider.GetWindow ();
            var window = (Window)this._container.Resolve (winType);

            window.Width = width;
            window.Height = height;

            return this;
        }

        public IWindowManager SizeToContent(SizeToContent sizeToContent)
        {
            Type winType = RegisterProvider.GetWindow ();
            var window = (Window)this._container.Resolve (winType);

            window.SizeToContent =sizeToContent;

            return this;
        }

        private void CornerRadius(CornerRadius cornerRadius)
        {
            Type winType = RegisterProvider.GetWindow ();
            var window = (Window)this._container.Resolve (winType);

            var windowChrome = WindowChrome.GetWindowChrome (window);
            windowChrome.CornerRadius = cornerRadius;
        }
    }
}
