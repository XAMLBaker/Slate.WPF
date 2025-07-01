using System;
using System.Collections.Generic;

namespace Slate.Avalonia
{
    public class ModuleCatalog : IModuleCatalog
    {
        private List<IModule> _modules;

        public ModuleCatalog()
        {
            _modules = new List<IModule>();
        }

        public IModuleCatalog AddModule<T>()
        {
            var module = (IModule)Activator.CreateInstance (typeof (T));

            //Assembly asm = typeof (T).Assembly;

            //using (var stream = asm.GetManifestResourceStream (asm.GetName ().Name + ".g.resources"))
            //{
            //    if (stream != null)
            //    {
            //        using (var reader = new ResourceReader (stream))
            //        {
            //            foreach (System.Collections.DictionaryEntry entry in reader)
            //            {
            //                string resourceKey = (string)entry.Key;

            //                ResourceDictionaryHelper.MergeResourceDictionary (asm.GetName ().Name, resourceKey);
            //                // resourceKey에는 예: "themes/generic.baml", "resources/mystyles.baml" 등 BAML 파일명 포함됨
            //                Console.WriteLine (resourceKey);
            //            }
            //        }
            //    }
            //}

            _modules.Add (module);

            return this;
        }

        public List<IModule> GetModules() => this._modules;
    }
}
