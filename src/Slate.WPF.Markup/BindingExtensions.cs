using System.Windows.Data;


namespace Slate.WPF.Markup
{
    public static class BindingExtensions
    {

        // 1) Expression<Func<>> 받아서 자동으로 path 추출 → 내부에서 Func 오버로드 호출
        public static TBindable Bind<TBindable, TContext, TValue>(
            this TBindable bindable,
            DependencyProperty targetProperty,
            System.Linq.Expressions.Expression<Func<TContext, TValue>> expression,
            TContext source,
            BindingMode mode = BindingMode.Default,
            IValueConverter? converter = null)
            where TBindable : FrameworkElement
            where TContext : class
        {
            if (expression == null)
                throw new ArgumentNullException (nameof (expression));
            if (bindable == null)
                throw new ArgumentNullException (nameof (bindable));
            if (source == null)
                throw new ArgumentNullException (nameof (source));

            var path = GetMemberName (expression);
            var getter = expression.Compile ();

            return bindable.Bind (targetProperty, getter, path, source, mode, converter);
        }
// 2) Func + 명시적 path 받는 오버로드 (static lambda 지원)
    public static TBindable Bind<TBindable, TContext, TValue>(
        this TBindable bindable,
        DependencyProperty targetProperty,
        Func<TContext, TValue> getter,
        string path,
        TContext source,
        BindingMode mode = BindingMode.Default,
        IValueConverter? converter = null)
        where TBindable : FrameworkElement
        where TContext : class
        {
            if (getter == null)
                throw new ArgumentNullException (nameof (getter));
            if (bindable == null)
                throw new ArgumentNullException (nameof (bindable));
            if (source == null)
                throw new ArgumentNullException (nameof (source));
            if (string.IsNullOrEmpty (path))
                throw new ArgumentException ("Path cannot be null or empty", nameof (path));

            var binding = new Binding (path)
            {
                Source = source,
                Mode = mode,
                Converter = converter
            };

            bindable.SetBinding (targetProperty, binding);
            return bindable;
        }

        // MemberName 추출 함수 (UnaryExpression 여러 단계도 안전하게 처리)
        private static string GetMemberName<T, TProp>(System.Linq.Expressions.Expression<Func<T, TProp>> expression)
        {
            System.Linq.Expressions.Expression expr = expression.Body;

            while (true)
            {
                switch (expr)
                {
                    case System.Linq.Expressions.MemberExpression member:
                        return member.Member.Name;
                    case System.Linq.Expressions.UnaryExpression unary:
                        expr = unary.Operand;
                        continue;
                    default:
                        throw new InvalidOperationException ("Expression must be a simple property access like 'x => x.Prop'");
                }
            }
        }

        public static T Content<T>(this T control, IState state) where T : ContentControl
        {
            control.SetBinding (ContentControl.ContentProperty, new Binding ("Value")
            {
                Source = state,
            });
            return control;
        }
        public static T Link<T>(
                        this T control,
                        DependencyProperty property,
                        string path,
                        object source = null,
                        RelativeSource relativeSource = null,
                        UpdateSourceTrigger? updateSourceTrigger = null,
                        IValueConverter? converter = null) where T : FrameworkElement
        {
            var binding = new Binding (path);
            if (source != null)
            {
                binding.Source = source;
            }

            if (relativeSource != null)
            {
                binding.RelativeSource = relativeSource;
            }

            if (converter != null)
            {
                binding.Converter = converter;
            }

            if (updateSourceTrigger != null)
            {
                binding.UpdateSourceTrigger = updateSourceTrigger.Value;
            }

            return control.Binding (property, binding);
        }


        public static ContentControl Link(this ContentControl control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            return control.Binding (ContentControl.ContentProperty, binding);
        }
        public static TextBlock Link(this TextBlock control, string viewModelProperty, IValueConverter? converter = null)
        {
            var binding = new Binding (viewModelProperty);

            if (converter != null)
                binding.Converter = converter;

            return control.Binding (TextBlock.TextProperty, binding);
        }
        public static ItemsControl Link(this ItemsControl control, string viewModelProperty)
        {
            return control.Binding (ItemsControl.ItemsSourceProperty, new Binding (viewModelProperty));
        }
        public static T Link<T>(this T control, string viewModelProperty) where T : ListBox
        {
            return control.Binding (ItemsControl.ItemsSourceProperty, new Binding (viewModelProperty));
        }
    }
}
