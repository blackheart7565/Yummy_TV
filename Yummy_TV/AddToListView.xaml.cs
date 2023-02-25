using System.Windows;
using Yummy_TV.Core;
using Yummy_TV.ViewModel;

namespace Yummy_TV {
    /// <summary>
    /// Interaction logic for AddToListView.xaml
    /// </summary>
    public partial class AddToListView : Window {

        SerializerToJson serializerToJson = new SerializerToJson();

        public AddToListView() {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e) => this.Close();

        private void ButtonAdd_Click(object sender, RoutedEventArgs e) {
            AllNavigationCollection.AllListCollection.Add(
                new Model.ModelListView(                    
                    textBoxName.Text,
                    textBoxOriginalName.Text
                    ) 
                );
            for (int i = 0; i < AllNavigationCollection.AllListCollection.Count; i++) {
                AllNavigationCollection.AllListCollection[i].ID = i;
            }
            this.Close();

            serializerToJson.SaveFIleJson(AllNavigationCollection.AllListCollection, "FullListJson");
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            DragMove();
        }
    }
}
