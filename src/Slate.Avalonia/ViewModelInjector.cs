using Avalonia;
using Avalonia.Controls;
using DryIoc;

namespace Slate.Avalonia
{
    public class ViewModelInjector
    {
        public static readonly AttachedProperty<bool> AutoWireViewModelProperty =
            AvaloniaProperty.RegisterAttached<ViewModelInjector, Control, bool>(
                "AutoWireViewModel", false);

        public static void SetAutoWireViewModel(AvaloniaObject element, bool value)
            => element.SetValue(AutoWireViewModelProperty, value);

        public static bool GetAutoWireViewModel(AvaloniaObject element)
            => element.GetValue(AutoWireViewModelProperty);
        static ViewModelInjector()
        {
            AutoWireViewModelProperty.Changed.AddClassHandler<Control>((control, e) =>
            {
                if ((bool)e.OldValue || control is not Control view)
                    return;
                var mapper = RegisterProvider.Container.Resolve<IViewModelMapper>();
                var mapping = mapper.GetViewModel(control.GetType());
                if (mapping is null)
                    return;

                var (vmType, reuse) = mapping.Value;
                var vm = ViewModelFactory.ResolveOrCreate(vmType, reuse);
                control.DataContext = vm;
                    
            });
        }
    }
}
