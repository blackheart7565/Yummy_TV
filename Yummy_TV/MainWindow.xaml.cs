using System.Windows;

namespace Yummy_TV {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonMinimizate_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
        private void ButtonMaxmized_Click(object sender, RoutedEventArgs e) {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }
    }
}
