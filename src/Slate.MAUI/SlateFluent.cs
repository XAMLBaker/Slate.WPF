namespace Slate.MAUI
{
    internal class SlateFluent : Fluent
    {
        public SlateFluent()
        {
            this.Services.AddSingleton<ILayoutNavigator, LayoutNavigator<View>> ();
        }

        public override void Run()
        {
            this.Init ();
            //Application.Current.MainWindow = (Window)RegisterProvider.Window;
            //Application.Current.MainWindow.Show ();
            var navi = (ILayoutNavigator)RegisterProvider.Get<ILayoutNavigator> ();

            navi.NavigateToAsync (this._register.InitialLayout.Namespace);
        }
    }
}
