using System.Windows;
using System.Windows.Input;

namespace Slate.WPF
{
    /// <summary>
    /// Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SlateWindow : Window
    {
        public SlateWindow()
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
