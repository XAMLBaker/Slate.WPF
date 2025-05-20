using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace FlexMVVM.WPF
{
    public class ContainerRegistry<T> : IContainerRegistry where T : DependencyObject
    {
        private readonly ServiceCollection _services = new ServiceCollection ();

        public ContainerRegistry()
        {
            // Lazy-load the ConfigurationManager, so it isn't created if it is never used.
            // Don't capture the 'this' variable in AddSingleton, so MauiAppBuilder can be GC'd.
            var configuration = new Lazy<ConfigurationManager> (() => new ConfigurationManager ());
            _services.AddSingleton<IConfiguration> (sp => configuration.Value);
        }

        public IContainerRegistry RegisterWindow<T>()
        {
            Type type = typeof (T);
            string _key = type.FullName;

            RegisterProvider.AddRegister (_key, type);
            return this;
        }

        public IContainerRegistry RegisterWindow<T>(Func<T> window)
        {
            string _key = window.GetType ().FullName;

            RegisterProvider.AddRegister (_key, window.GetType ());
            return this;
        }

        public IContainerRegistry RegisterLayout<T>()
        {
            Type type = typeof (T);
            string _key = type.FullName;

            RegisterProvider.AddRegister (_key, type);
            return this;
        }

        public IContainerRegistry RegisterLayout<T>(Func<T> layout)
        {
            string _key = layout.GetType ().FullName;

            RegisterProvider.AddRegister (_key, layout.GetType ());
            return this;
        }

        public IContainerRegistry RegisterComponent<T>()
        {
            Type type = typeof (T);
            string _key = type.FullName;

            RegisterProvider.AddRegister (_key, type);

            return this;
        }

        public IContainerRegistry RegisterComponent<T>(Func<T> component)
        {
            string _key = component.GetType ().FullName;

            RegisterProvider.AddRegister (_key, component.GetType ());
            return this;
        }
        public IServiceCollection Services => this._services;
    }
}
