using FlexMVVM.Modularity;
using FlexMVVM.WPF;
using System.Windows;

namespace FlexMVVM
{
    public sealed class FlexApp
    {
        public static FlexAppBuilder CreateBuilder()
        {
            return new FlexAppBuilder (new ContainerRegistry<DependencyObject>(),
                                       new ModuleCatalog<IModule>());
        }
    }
}
