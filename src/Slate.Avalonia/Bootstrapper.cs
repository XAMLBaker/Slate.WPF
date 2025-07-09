using Avalonia;

namespace Slate.Avalonia
{
    public class Bootstrapper : BootStrapperBase
    {
        public Bootstrapper(Application application) {
            this._fluent = new SlateFluent (application);
        }
    }
}
