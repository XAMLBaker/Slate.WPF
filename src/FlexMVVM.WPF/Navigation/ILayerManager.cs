using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace FlexMVVM.WPF.Navigation
{
    public interface ILayerManager
    {
        void Build(string path, IList<Type> types);
        void Run(IList<Type> types);
        void Run(string path);
    }

    public class LayerManager : ILayerManager
    {
        private readonly IContainer _container;
        private Dictionary<string, UIElement> layers;
        public LayerManager(IContainer container)
        {
            this._container = container;
        }

        public void Build(string path, IList<Type> types)
        {
            if (layers.ContainsKey (path))
            {
                throw new Exception ("중복된 path 입니다.");
            }
        }

        public void Run(IList<Type> types)
        {
            LayerPress (types);
        }

        public void Run(string path)
        {
            if (layers.ContainsKey (path))
            {
                throw new Exception ("존재하지 않는 path 입니다.");
            }
            var aa = layers[path];
        }

        private void LayerPress(IList<Type> types)
        {
            var rootElement = types.First ();
            var childElements = types.Take (1);

            foreach (Type t in childElements)
            {
            }
        }

        private void Clear()
        {

        }
    }
}
