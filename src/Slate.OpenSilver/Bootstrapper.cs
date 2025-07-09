using System.Windows;

namespace Slate.OpenSilver
{
    public class Bootstrapper : BootStrapperBase
    {
        public Bootstrapper()
        {
            this._fluent = new SlateAppFluent ();
        }
    }
}
