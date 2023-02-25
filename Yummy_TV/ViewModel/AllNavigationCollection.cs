using System.Collections.ObjectModel;
using Yummy_TV.Model;

namespace Yummy_TV.ViewModel {
    public class AllNavigationCollection {
        public static ObservableCollection<ModelListView> AllListCollection { get; set; } = new ObservableCollection<ModelListView>();
        public static ObservableCollection<ModelListView> ViewMomentCollection { get; set; } = new ObservableCollection<ModelListView>();
        public static ObservableCollection<ModelListView> ViewPlansCollection { get; set; } = new ObservableCollection<ModelListView>();
        public static ObservableCollection<ModelListView> ViewedCollection { get; set; } = new ObservableCollection<ModelListView>();
        public static ObservableCollection<ModelListView> FavouriteCollection { get; set; } = new ObservableCollection<ModelListView>();
    }
}
