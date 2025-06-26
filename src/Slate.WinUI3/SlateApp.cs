using Microsoft.UI.Xaml;

namespace Slate.WinUI3
{
    public sealed class SlateApp
    {
        public static SlateAppBuilder CreateBuilder()
        {
            return new SlateAppBuilder (new ContainerRegistry<DependencyObject>(),
                                       new ModuleCatalog());
        }
    }
}
