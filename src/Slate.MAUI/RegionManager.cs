using System.Collections.Generic;
using System.Windows;
namespace Slate.MAUI
{
    public interface IStatefulControl
    {
        void OnAttach();
        void OnDetach();
    }

    public static class RegionManager
    {
        private static readonly Dictionary<string, SlateRegionControl> _regions = new ();
        private static readonly Dictionary<string, ContentView> _attachedControls = new ();

        public static void RegisterRegion(string name, SlateRegionControl host)
        {
            _regions[name] = host;

            if (_attachedControls.TryGetValue (name, out var control))
            {
                host.Content = control;
                if (control is IStatefulControl stateful)
                {
                    stateful.OnAttach ();
                }
            }
        }

        public static void Attach(string name, ContentView control)
        {
            // MAUI에서는 직접 부모를 제거하는 방식이 없으므로
            // 중복 추가만 피하도록 방어 로직을 둠
            if (_attachedControls.TryGetValue (name, out var existing) && existing == control)
                return;

            _attachedControls[name] = control;

            if (_regions.TryGetValue (name, out var host))
            {
                host.Content = control;

                if (control is IStatefulControl stateful)
                {
                    stateful.OnAttach ();
                }
            }
        }

        public static void Detach(string name)
        {
            if (_attachedControls.TryGetValue (name, out var control))
            {
                if (_regions.TryGetValue (name, out var host))
                {
                    host.Content = null;
                }

                if (control is IStatefulControl stateful)
                {
                    stateful.OnDetach ();
                }

                _attachedControls.Remove (name);
            }
        }
    }
}
