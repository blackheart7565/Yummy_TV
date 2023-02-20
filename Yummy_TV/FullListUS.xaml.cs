using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Yummy_TV.Model;
using Yummy_TV.ViewModel;

namespace Yummy_TV {
    /// <summary>
    /// Interaction logic for FullListUS.xaml
    /// </summary>
    public partial class FullListUS : UserControl {

        public FullListUS()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e) {
            AddToListView addToList = new();
            addToList.ShowDialog();
        }

        private void AddFilterList_Click(object sender, System.Windows.RoutedEventArgs e) {
            AddToFilter filter = new();
            filter.ShowDialog();
        }
    }
}
