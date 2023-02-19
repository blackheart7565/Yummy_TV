using System.Collections.ObjectModel;
using Yummy_TV.Core;
using Yummy_TV.Model;

namespace Yummy_TV.ViewModel {
    public class FullListVM : PropertyChangedBase {
        public ObservableCollection<ModelListView> modelListViewsCollection { get; set; } = new ObservableCollection<ModelListView>() {
            new ModelListView() { 
                Name= "Аватар 2: Путь воды", 
                OriginalName="Avatar 2: The Way of Water"
            },
         };
    }
}
