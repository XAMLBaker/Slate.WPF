using Microsoft.UI.Xaml.Controls;

namespace Slate.WinUI3.Markup
{
    public interface IComponent
    {
        void Render();
    }

    // CommunityToolkit.Mvvm의 [INotifyPropertyChanged] 사용한다고 가정
    [INotifyPropertyChanged]
    public abstract partial class Component : ContentControl, IComponent, IShellComponent
    {
        public object? ComponentStyleKey { get; set; }

        protected virtual void OnLoaded(object sender, RoutedEventArgs e)
        {

        }
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate ();

            this.DataContext = this;
            this.Loaded += this.OnLoaded;
            this.Render ();

        }

        // WPF의 OnInitialized는 없으니 필요하면 생성자나 Loaded에서 처리
        // protected override void OnApplyTemplate() { base.OnApplyTemplate(); }

        protected virtual void OnRender(object sender)
        {
            // 서브클래스 재정의용
        }

        public void Render()
        {
            InitilzedForms ();

            UIElement? element = Build ();

            if (element != null)
            {
                this.Content = element;
            }

            OnRender (this);
        }

        protected virtual void InitilzedForms()
        {
            // 초기화 작업
        }

        protected abstract UIElement Build();

        public virtual void RegionAttached(object argu)
        {
            // 필요 시 재정의
        }

        protected void RegionSet(string regionName)
        {
            RegionManager.Attach (regionName, this);
        }
    }
}
