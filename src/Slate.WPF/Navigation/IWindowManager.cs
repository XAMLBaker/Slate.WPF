using DryIoc;
using System;
using System.Windows;
using System.Windows.Shell;

namespace Slate.WPF
{
    public interface IWindowManager
    {
        void CornerRadius(double all);
        void CornerRadius(double leftRight, double topBottom);
        void CornerRadius(double left, double top, double right, double bottom);
    }

    public class WindowManager : IWindowManager
    {
        private readonly IContainer _container;

        public WindowManager(IContainer container)
        {
            this._container = container;
        }
        public void CornerRadius(double all)
        {
            CornerRadius (new CornerRadius (all));
        }

        public void CornerRadius(double leftRight, double topBottom)
        {
            CornerRadius (new CornerRadius (leftRight, topBottom, leftRight, topBottom));
        }

        public void CornerRadius(double left, double top, double right, double bottom)
        {
            CornerRadius (new CornerRadius (left, top, right, bottom));
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
