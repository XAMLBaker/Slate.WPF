using Windows.Foundation;
using Windows.System;

namespace MarkupChain.WinUI3.Input
{
    public static class KeyboardAcceleratorExtensions
    {
        public static T Modifiers<T>(this T keyboardAccelerator, VirtualKeyModifiers modifiers) where T : KeyboardAccelerator
        {
            keyboardAccelerator.SetValue (KeyboardAccelerator.ModifiersProperty, modifiers);

            return keyboardAccelerator;
        }

        public static T IsEnable<T>(this T keyboardAccelerator, bool isEnable) where T : KeyboardAccelerator
        {
            keyboardAccelerator.SetValue (KeyboardAccelerator.IsEnabledProperty, isEnable);

            return keyboardAccelerator;
        }
        public static T Key<T>(this T keyboardAccelerator, VirtualKey key) where T : KeyboardAccelerator
        {
            keyboardAccelerator.SetValue (KeyboardAccelerator.KeyProperty, key);

            return keyboardAccelerator;
        }

        public static T Invoke<T>(this T keyboardAccelerator, TypedEventHandler<KeyboardAccelerator, KeyboardAcceleratorInvokedEventArgs> action) where T : KeyboardAccelerator
        {
            keyboardAccelerator.Invoked += action;

            return keyboardAccelerator;
        }
    }
}
