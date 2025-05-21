using System.Windows;
using System.Windows.Input;

namespace FlexMVVM.WPF
{
    /// <summary>
    /// Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FlexWindow : Window
    {
        public FlexWindow()
        {
            InitializeComponent ();
            this.MouseLeftButtonDown += WindowStyle_MouseLeftButtonDown;
        }

        private void WindowStyle_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove ();
        }
    }
}
