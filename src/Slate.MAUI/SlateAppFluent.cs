namespace Slate.MAUI
{
    internal class SlateAppFluent : SlateFluent
    {
        public SlateAppFluent()
        {
            this.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<View>> ();
        }

        public override void Run()
        {
            this.Init ();
            //Application.Current.MainWindow = (Window)RegisterProvider.Window;
            //Application.Current.MainWindow.Show ();
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (RegisterProvider.GetDefineNestedLayout.Namespace);
        }
    }
}
