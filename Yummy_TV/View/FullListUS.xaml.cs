using System.Windows.Controls;

namespace Yummy_TV.View {
    /// <summary>
    /// Interaction logic for FullListUS.xaml
    /// </summary>
    public partial class FullListUS : UserControl {

        public static int Index;

        public FullListUS() {
            InitializeComponent();
        }

        private void AddFilterList_Click(object sender, System.Windows.RoutedEventArgs e) {
            Index = (int)((Button)sender).Tag;
            AddToFilter filter = new();
            filter.ShowDialog();
        }
    }
}
