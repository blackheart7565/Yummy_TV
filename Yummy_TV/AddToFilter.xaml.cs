using System;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Yummy_TV.Core;
using Yummy_TV.ViewModel;

namespace Yummy_TV {
    /// <summary>
    /// Interaction logic for AddToFilter.xaml
    /// </summary>
    public partial class AddToFilter : Window {

        private SerializerToJson serializerToJson;

        public AddToFilter() {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }

        private void SaveToList_Click(object sender, RoutedEventArgs e) {
            switch (ComboBoxStatus.SelectedIndex) {
                case 0: {
                        if (!(AllNavigationCollection.ViewMomentCollection.Any(x =>
                                                x.Name == AllNavigationCollection.AllListCollection[FullListUS.Index].Name &&
                                                x.OriginalName == AllNavigationCollection.AllListCollection[FullListUS.Index].OriginalName))) {
                            AllNavigationCollection.ViewMomentCollection.Add(AllNavigationCollection.AllListCollection[FullListUS.Index]);

                            for (int i = 0; i < AllNavigationCollection.ViewMomentCollection.Count; i++) {
                                AllNavigationCollection.ViewMomentCollection[i].ID = i;
                            }

                            serializerToJson = new SerializerToJson();
                            serializerToJson.SaveFIleJson(AllNavigationCollection.ViewMomentCollection, "ViewMomentListJson");
                            this.Close();
                        }
                    }
                    break;

                case 1: {
                        if (!(AllNavigationCollection.ViewPlansCollection.Any(x =>
                        x.Name == AllNavigationCollection.AllListCollection[FullListUS.Index].Name &&
                        x.OriginalName == AllNavigationCollection.AllListCollection[FullListUS.Index].OriginalName))) {
                            AllNavigationCollection.ViewPlansCollection.Add(AllNavigationCollection.AllListCollection[FullListUS.Index]);

                            for (int i = 0; i < AllNavigationCollection.ViewPlansCollection.Count; i++) {
                                AllNavigationCollection.ViewPlansCollection[i].ID = i;
                            }

                            serializerToJson = new SerializerToJson();
                            serializerToJson.SaveFIleJson(AllNavigationCollection.ViewPlansCollection, "ViewPlansListJson");
                            this.Close();
                        }
                    }
                    break;

                case 2: {
                        if (!(AllNavigationCollection.ViewedCollection.Any(x =>
                                                x.Name == AllNavigationCollection.AllListCollection[FullListUS.Index].Name &&
                                                x.OriginalName == AllNavigationCollection.AllListCollection[FullListUS.Index].OriginalName))) {
                            AllNavigationCollection.ViewedCollection.Add(AllNavigationCollection.AllListCollection[FullListUS.Index]);

                            for (int i = 0; i < AllNavigationCollection.ViewedCollection.Count; i++) {
                                AllNavigationCollection.ViewedCollection[i].ID = i;
                            }

                            serializerToJson = new SerializerToJson();
                            serializerToJson.SaveFIleJson(AllNavigationCollection.ViewedCollection, "ViewedListJson");
                            this.Close();
                        }
                    }
                    break;

                case 3: {
                        if (!(AllNavigationCollection.FavouriteCollection.Any(x =>
                                                x.Name == AllNavigationCollection.AllListCollection[FullListUS.Index].Name &&
                                                x.OriginalName == AllNavigationCollection.AllListCollection[FullListUS.Index].OriginalName))) {
                            AllNavigationCollection.FavouriteCollection.Add(AllNavigationCollection.AllListCollection[FullListUS.Index]);

                            for (int i = 0; i < AllNavigationCollection.FavouriteCollection.Count; i++) {
                                AllNavigationCollection.FavouriteCollection[i].ID = i;
                            }

                            serializerToJson = new SerializerToJson();
                            serializerToJson.SaveFIleJson(AllNavigationCollection.FavouriteCollection, "ViewedListJson");
                            this.Close();
                        }
                    }
                    break;
            }
        }
    }
}
