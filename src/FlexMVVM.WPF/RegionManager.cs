using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF
{
    public interface IStatefulControl
    {
        void OnAttach();
        void OnDetach();
    }

    public partial class RegionManager
    {
        private static readonly Dictionary<string, FlexRegion> _regions = new ();
        private static readonly Dictionary<string, UIElement> _attachedControls = new ();

        public static void RegisterRegion(string name, FlexRegion host)
        {
            _regions[name] = host;

            if (_attachedControls.TryGetValue (name, out var control))
            {
                host.Content = control;
            }
        }

        public static void Attach(string name, UIElement control)
        {
            // 기존 부모에서 제거 (필수! WPF는 동시에 하나의 부모만 허용)
            if (VisualTreeHelper.GetParent (control) is ContentControl parent)
            {
                parent.Content = null;
            }

            _attachedControls[name] = control;

            if (_regions.TryGetValue (name, out var host))
            {
                host.Content = control;
            }

            if (control is IStatefulControl stateful)
            {
                stateful.OnAttach ();
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

                //if (control is IStatefulControl stateful)
                //{
                //    stateful.OnDetach ();
                //}

                _attachedControls.Remove (name);
            }
        }
    }
}
