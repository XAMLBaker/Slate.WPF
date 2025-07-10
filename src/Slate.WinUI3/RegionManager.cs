using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System.Collections.Generic;

namespace Slate.WinUI3
{
    public interface IStatefulControl
    {
        void OnAttach();
        void OnDetach();
    }

    public partial class RegionManager
    {
        private static readonly Dictionary<string, SlateRegionControl> _regions = new ();
        private static readonly Dictionary<string, UIElement> _attachedControls = new ();

        public static void RegisterRegion(string name, SlateRegionControl host)
        {
            _regions[name] = host;

            if (_attachedControls.TryGetValue (name, out var control))
            {
                host.Content = control;
            }
        }

        public static void Attach(string name, UIElement control)
        {
            if (VisualTreeHelper.GetParent (control) is ContentControl parent)
            {
                parent.Content = null;
            }

            _attachedControls[name] = control;

            if (_regions.TryGetValue (name, out var host))
            {
                host.Content = control;
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
