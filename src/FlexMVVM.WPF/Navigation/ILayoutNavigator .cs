using DryIoc;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public interface ILayoutNavigator
    {
        void SetRootLayout();
        void Home();
        void NavigateTo(string url);
        UIElement CreateLayout(string url);
    }

    public class LayoutNavigator : ILayoutNavigator
    {
        private readonly IContainer _container;

        public LayoutNavigator(IContainer container)
        {
            this._container = container;
        }
        public void SetRootLayout()
        {
            Type winType = RegisterProvider.GetWindow();
            Type rootLayoutType = RegisterProvider.GetDefineNestedLayout();
            
            var winObject = (UIElement)this._container.Resolve (winType);
            var layOutObject = (UIElement)this._container.Resolve (rootLayoutType);
            if (winObject is Window window)
            {
                if(window.Content != null)
                {
                    if (window.Content is Panel panel)
                    {
                        panel.Children.Add (layOutObject);
                        return;
                    }
                }
                window.Content = layOutObject;
            }
        }

        public void Home()
        {
            Type rootLayoutType = RegisterProvider.GetDefineNestedLayout();

            if (rootLayoutType == null)
            {
                return;
            }

            var layOutObject = (UIElement)this._container.Resolve (rootLayoutType);
          
            if (layOutObject is DockPanel dockPanel)
            {
                Contentemove (dockPanel);
                bool _isGroupedWithRegion = IsGroupedWithContent (rootLayoutType.Namespace);
                if (_isGroupedWithRegion == false)
                    return;
                LayerPress (rootLayoutType);
            }
        }

        public void NavigateTo(string url)
        {
            string _url = url.Replace ('/', '.');

            Type rootLayoutType = RegisterProvider.GetDefineNestedLayout();

            UIElement layout = CreateLayout (_url);
            if (rootLayoutType == null)
            {
                if (RegisterProvider.Window is Window window)
                {
                    window.Content = layout;
                }
                return;
            }

            var layOutObject = (UIElement)this._container.Resolve (rootLayoutType);
            if (layOutObject is DockPanel dockPanel)
            {
                Contentemove (dockPanel);
                dockPanel.Children.Add (layout);
            }
       }

        public UIElement CreateLayout(string url)
        {
            try
            {
                if (RegisterProvider.HasPartialKeyMatch (url) == false)
                    throw new Exception ("Module 등록되지 않은 url 입니다.");

                bool _isGroupedWithLayout = IsGroupedWithLayout (url);
                bool _isGroupedWithContent = IsGroupedWithContent (url);

                if((_isGroupedWithLayout || _isGroupedWithContent) == false)
                    throw new Exception ("등록 된 Layout 또는 Content가 없습니다.");

                string typeNameSpace = _isGroupedWithLayout ? GetLayoutString (url) : GetContentString(url);
                Type contentType = RegisterProvider.GetType(typeNameSpace);
                if (_isGroupedWithLayout && _isGroupedWithContent)
                {
                    LayerPress (contentType);
                }

                string moduleName = contentType.Assembly.GetName ().Name;
                int layoutCnt = (contentType.Namespace.Split ('.').Length - moduleName.Split ('.').Length);

                UIElement rootPanel = null;
                for (int i = 0; i < layoutCnt; i++)
                {
                    var parentFolderUrl = RemoveLastSegment (contentType.Namespace);
                    rootPanel = CreateLayout ($"{parentFolderUrl}");
                }
                UIElement layOutObject = (UIElement)this._container.Resolve (contentType);

                if (rootPanel != null)
                {
                    Contentemove (rootPanel);
                    ((DockPanel)rootPanel).Children.Add (layOutObject);

                    return rootPanel;
                }

                return layOutObject;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        private string GetLayoutString(string url)
        {
            if (url.Split ('.').Last () == "Layout")
                return url;

            return $"{url}.Layout";
        }

        private string GetContentString(string url)
        {
            if (url.Split ('.').Last () == "Content")
                return url;

            return $"{url}.Content";
        }

        private bool IsGroupedWithLayout(string url)
        {
            if(url.Split('.').Last() == "Layout")
                return true;
            return RegisterProvider.IsUrlRegistered(GetLayoutString (url));
        }
        private bool IsGroupedWithContent(string url)
        {
            if (url.Split ('.').Last () == "Content")
                return true;
            return RegisterProvider.IsUrlRegistered (GetContentString (url));
        }

        private void LayerPress(Type layoutType)
        {
            var _region = layoutType.Assembly.DefinedTypes.Where (x => x.Namespace == layoutType.Namespace)
                                                         .First (x => x.Name == "Content");

            var layOutObject = (DockPanel)this._container.Resolve (layoutType);
            var regionObject = (FrameworkElement)this._container.Resolve (_region);

            Contentemove (layOutObject);
            layOutObject.Children.Add (regionObject);
        }

        private void Contentemove(UIElement dockPanel) {
            DockPanel _dockPanel = (DockPanel)dockPanel;
            UIElement dockofRegion = null;
            foreach (UIElement child in _dockPanel.Children)
            {
                // DockPanel.Dock 의 설정 상태를 확인
                var valueSource = DependencyPropertyHelper.GetValueSource (child, DockPanel.DockProperty);

                // Local 값으로 설정되지 않은 경우
                if (!valueSource.BaseValueSource.HasFlag (BaseValueSource.Local))
                {
                    dockofRegion = child;
                }
            }
            if (dockofRegion != null)
            {
                _dockPanel.Children.Remove (dockofRegion);
            }
        }

        private string RemoveLastSegment(string path)
        {
            int lastDot = path.LastIndexOf ('.');
            return lastDot >= 0 ? path.Substring (0, lastDot) : path;
        }
    }
}
