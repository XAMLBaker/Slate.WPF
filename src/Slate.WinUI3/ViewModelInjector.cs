using DryIoc;
using Microsoft.UI.Xaml;

namespace Slate.WinUI3
{
    public static class ViewModelInjector
    {
        public static IContainer _container { get; private set; }

        public static void SetContainer(IContainer container)
        {
            _container = container;
        }

        public static readonly DependencyProperty AutoWireViewModelProperty =
          DependencyProperty.RegisterAttached (
              "AutoWireViewModel",
              typeof (bool),
              typeof (ViewModelInjector),
              new PropertyMetadata (false, OnAutoWireViewModelChanged));

        public static void SetAutoWireViewModel(DependencyObject element, bool value)
            => element.SetValue (AutoWireViewModelProperty, value);

        public static bool GetAutoWireViewModel(DependencyObject element)
            => (bool)element.GetValue (AutoWireViewModelProperty);

        private static void OnAutoWireViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not FrameworkElement view || (bool)e.NewValue != true)
                return;

            var mapper = _container.Resolve<IViewModelMapper> ();
            var mapping = mapper.GetViewModel (view.GetType ());
            if (mapping is null)
                return;

            var (vmType, reuse) = mapping.Value;
            var vm = ViewModelFactory.ResolveOrCreate (vmType, reuse);
            view.DataContext = vm;
        }
    }
}
