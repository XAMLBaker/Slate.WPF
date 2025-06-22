namespace MarkupChain.WPF
{
    public static partial class DecoratorExtnesions
    {
        public static T Child<T>(this T fe, UIElement element) where T : Decorator
        {
            fe.Child = element;
            return fe;
        }
    }
}
