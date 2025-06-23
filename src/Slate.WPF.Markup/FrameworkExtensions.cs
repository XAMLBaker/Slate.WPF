using System.Windows.Data;

namespace Slate.WPF.Markup
{
    public static partial class FrameworkExtensions
    {
        public static T ActualHeight<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.ActualHeightProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T MaxWidth<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.MaxWidthProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T MinHeight<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.MinHeightProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T MinWidth<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.MinWidthProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Name<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.NameProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T OverridesDefaultStyle<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.OverridesDefaultStyleProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Style<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.StyleProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T ToolTip<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.ToolTipProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T UseLayoutRounding<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.UseLayoutRoundingProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T VerticalAlignment<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.VerticalAlignmentProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Width<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.WidthProperty, new Binding ("Value")
            {
                Source = state,
            });
        }

        public static T MaxHeight<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.MaxHeightProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Margin<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.MarginProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Tag<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.TagProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T LayoutTransform<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.LayoutTransformProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T ActualWidth<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.ActualWidthProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T BindingGroup<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.BindingGroupProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T ContextMenu<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.ContextMenuProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Cursor<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.CursorProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T DataContext<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.DataContextProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T FlowDirection<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.FlowDirectionProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T ForceCursor<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.ForceCursorProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Height<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.HeightProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T HorizontalAlignment<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.HorizontalAlignmentProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T InputScope<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.InputScopeProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
        public static T Language<T>(this T cc, IState state) where T : FrameworkElement
        {
            return cc.Binding (FrameworkElement.LanguageProperty, new Binding ("Value")
            {
                Source = state,
            });
        }
    }
}
