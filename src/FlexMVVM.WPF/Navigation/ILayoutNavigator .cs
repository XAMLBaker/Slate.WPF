using DryIoc;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FlexMVVM.WPF
{
    public interface ILayoutNavigator
    {
        void SetRootLayout();
        void Home();
        void NavigateTo(string url);
        FrameworkElement CreateLayout(string url);
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
            
            var winObject = (FrameworkElement)this._container.Resolve (winType);
            var layOutObject = (FrameworkElement)this._container.Resolve (rootLayoutType);
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

            var layOutObject = (FrameworkElement)this._container.Resolve (rootLayoutType);
          
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
            if(url[0] == '/' || url[0] == '.')
            {
                url = url.Remove (0,1);
            }
            string _url = url.Replace ('/', '.');

            Type rootLayoutType = RegisterProvider.GetDefineNestedLayout();

            FrameworkElement layout = CreateLayout (_url);
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

        public FrameworkElement CreateLayout(string url)
        {
            try
            {
                var layout = GetLayout (url);

                bool _isGroupedWithLayout = IsGroupedWithLayout (url);
                bool _isGroupedWithContent = IsGroupedWithContent (url);
                string typeNameSpace = _isGroupedWithLayout ? GetLayoutString (url) : GetContentString (url);
                Type contentType = RegisterProvider.GetType (typeNameSpace);

                string moduleName = contentType.Assembly.GetName ().Name;
                int layoutCnt = (contentType.Namespace.Split ('.').Length - moduleName.Split ('.').Length);

                FrameworkElement rootLayout = layout;
                string parentFolderUrl = RemoveLastSegment (contentType.Namespace);
                for (int i = 0; i < layoutCnt; i++)
                {
                    rootLayout = ParentPress (parentFolderUrl, rootLayout);
                    parentFolderUrl = RemoveLastSegment (parentFolderUrl);
                }

                return rootLayout;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public FrameworkElement ParentPress(string url, FrameworkElement children)
        {
            var layout = GetLayout (url);

            bool _isGroupedWithLayout = IsGroupedWithLayout (url);
            string typeNameSpace = _isGroupedWithLayout ? GetLayoutString (url) : GetContentString (url);
            Type contentType = RegisterProvider.GetType (typeNameSpace);

            if (layout is DockPanel dockPanel)
            {
                Contentemove (dockPanel);
                ((DockPanel)dockPanel).Children.Add (children);
            }
            else if (layout is ContentControl cc)
            {
                cc.Content = layout;
            }

            return layout;
        }

        private FrameworkElement GetLayout(string url)
        {
            if (RegisterProvider.HasPartialKeyMatch (url) == false)
                throw new Exception ("Module 등록되지 않은 url 입니다.");

            bool _isGroupedWithLayout = IsGroupedWithLayout (url);
            bool _isGroupedWithContent = IsGroupedWithContent (url);

            if ((_isGroupedWithLayout || _isGroupedWithContent) == false)
                throw new Exception ("등록 된 Layout 또는 Content가 없습니다.");

            string typeNameSpace = _isGroupedWithLayout ? GetLayoutString (url) : GetContentString (url);
            Type contentType = RegisterProvider.GetType (typeNameSpace);
            if (_isGroupedWithLayout && _isGroupedWithContent)
            {
                LayerPress (contentType);
            }

            return (FrameworkElement)this._container.Resolve (contentType);
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
            FrameworkElement dockofRegion = null;
            foreach (FrameworkElement child in _dockPanel.Children)
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
