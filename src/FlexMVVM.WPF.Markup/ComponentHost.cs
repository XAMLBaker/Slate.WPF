using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace FlexMVVM.WPF.Markup
{
    public class ComponentHost
    {
        private static readonly List<IComponent> _activeComponents = new ();

        public static void Register(IComponent component)
        {
            if (!_activeComponents.Contains (component))
                _activeComponents.Add (component);
        }

        public static IEnumerable<IComponent> GetActiveComponents()
            => _activeComponents;

        public static IComponent Get(Type type)
        {
            return _activeComponents.FirstOrDefault(x=>x.GetType() == type);
        }
    }
}
