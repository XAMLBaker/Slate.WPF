using Avalonia.Controls;

namespace Slate.Avalonia
{
    public sealed class SlateApp
    {
        public static SlateAppBuilder CreateBuilder()
        {
            return new SlateAppBuilder (new ContainerRegistry<Control>(),
                                       new ModuleCatalog());
        }
    }
}
