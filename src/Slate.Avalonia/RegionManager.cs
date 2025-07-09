using System.Collections.Generic;
using Avalonia.Controls;

namespace Slate.Avalonia
{
    public interface IStatefulControl
    {
        void OnAttach();
        void OnDetach();
    }

    public partial class RegionManager
    {
        private static readonly Dictionary<string, ContentControl> _regions = new Dictionary<string, ContentControl> ();
        private static readonly Dictionary<string, ContentControl> _attachedControls = new Dictionary<string, ContentControl> ();

        public static void RegisterRegion(string name, ContentControl host)
        {
            _regions[name] = host;

            if (_attachedControls.TryGetValue (name, out var control))
            {
                host.Content = control;
            }
        }

        public static void Attach(string name, ContentControl control)
        {
            // 기존 부모에서 제거 (필수! WPF는 동시에 하나의 부모만 허용)
            if (control.Parent is ContentControl parent)
            {
                parent.Content = null;
            }

            _attachedControls[name] = control;

            if (_regions.TryGetValue (name, out var host))
            {
                ((SlateRegionControl)host).BindableContent = control;
            }

            //if (control is IStatefulControl stateful)
            //{
            //    stateful.OnAttach ();
            //}
        }

        public static void Detach(string name)
        {
            if (_attachedControls.TryGetValue (name, out var control))
            {
                if (_regions.TryGetValue (name, out var host))
                {
                    host.Content = null;
                }

                //if (control is IStatefulControl stateful)
                //{
                //    stateful.OnDetach ();
                //}

                _attachedControls.Remove (name);
            }
        }
    }
}
