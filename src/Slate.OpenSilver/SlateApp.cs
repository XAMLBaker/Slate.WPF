using System.Windows;

namespace Slate.OpenSilver
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
