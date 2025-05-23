using System;
using System.Windows;

namespace FlexMVVM.WPF
{
    public partial class FlexFluent
    {
        public FlexFluent Window<T>(Func<T> window) where T : Window
        {
            _register.RegisterMap["FlexFrameworkWindow"] = typeof (T);
            return this;
        }

        public FlexFluent DefineNestedLayout<T>()
        {
            _register.NestedLayout = typeof (T);
            return this;
        }

        public FlexFluent DefineNestedLayout<T>(Func<T> content)
        {
            _register.NestedLayout = typeof (T);
            return this;
        }

        public FlexFluent StartWithLayout<T>()
        {
            if (_register.InitialLayout != null)
                throw new InvalidOperationException ("초기 Layout은 이미 설정되었습니다.");
            _register.InitialLayout = typeof (T);
            return this;
        }

        public FlexFluent StartWithLayout<T>(Func<T> content)
        {
            if (_register.InitialLayout != null)
                throw new InvalidOperationException ("초기 Layout은 이미 설정되었습니다.");
            _register.InitialLayout = typeof (T);
            return this;
        }
    }
}
