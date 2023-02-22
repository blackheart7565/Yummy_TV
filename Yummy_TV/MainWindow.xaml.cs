using System.Runtime.InteropServices;
using System;
using System.Windows;
using System.Windows.Interop;
using Yummy_TV.ViewModel;
using Yummy_TV.Core;

namespace Yummy_TV {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private SerializerToJson serializerToJson;
        
        public MainWindow() {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void ButtonMinimizate_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void ButtonMaxmized_Click(object sender, RoutedEventArgs e) {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void Border_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            AllNavigationCollection.AllListCollection = new SerializerToJson("FullListJson").LoadFileJson();
            AllNavigationCollection.ViewMomentCollection = new SerializerToJson("ViewMomentListJson").LoadFileJson();
            AllNavigationCollection.ViewPlansCollection = new SerializerToJson("ViewPlansListJson").LoadFileJson();
        }
    }
}
