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
        private static readonly Dictionary<string, SlateRegionControl> _regions = new Dictionary<string, SlateRegionControl> ();
        private static readonly Dictionary<string, Control> _attachedControls = new Dictionary<string, Control> ();

        public static void RegisterRegion(string name, SlateRegionControl host)
        {
            _regions[name] = host;

            if (_attachedControls.TryGetValue (name, out var control))
            {
                host.Content = control;
            }
        }

        public static void Attach(string name, Control control)
        {
            // 기존 부모에서 제거 (필수! WPF는 동시에 하나의 부모만 허용)
            if (control.Parent is ContentControl parent)
            {
                parent.Content = null;
            }

            _attachedControls[name] = control;

            if (_regions.TryGetValue (name, out var host))
            {
                host.BindableContent = control;
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
