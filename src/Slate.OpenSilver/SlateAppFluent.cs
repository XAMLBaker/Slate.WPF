using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Slate.OpenSilver
{
    internal class SlateAppFluent : SlateFluent
    {
        public SlateAppFluent()
        {
            this.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<FrameworkElement>> ();
        }

        public override void Run()
        {
            this.Init ();
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
        }
    }
}
