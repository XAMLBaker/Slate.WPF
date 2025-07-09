using DryIoc;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

namespace Slate.WinUI3
{
    public interface IMainWindowManager
    {

    }

    public class MainWindowManager : IMainWindowManager
    {
        private readonly IContainer _container;

        public MainWindowManager(IContainer container)
        {
            this._container = container;
        }
    }
}
