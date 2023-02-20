using System.Collections.ObjectModel;
using System.Windows.Input;
using Yummy_TV.Core;
using Yummy_TV.Model;

namespace Yummy_TV.ViewModel {
    public class FullListVM : PropertyChangedBase {
        public ObservableCollection<ModelListView> modelListViewsCollection { get; set; } = new ObservableCollection<ModelListView>() {
            new ModelListView() { 
                Image = "/Resources/Image/logo_2.jpg",
                Name= "Аватар 2: Путь воды", 
                OriginalName="Avatar 2: The Way of Water"
            },
            new ModelListView() {
                Image = "/Resources/Image/logo_1.jpg",
                Name= "Человек-паук: Нет пути", 
                OriginalName="Spider-Man: There is no Way"
            },
            new ModelListView() {
                Image = "/Resources/Image/logo_1.jpg",
                Name= "Человек-паук: Нет пути", 
                OriginalName="Spider-Man: There is no Way"
            },
            new ModelListView() {
                Image = "/Resources/Image/logo_1.jpg",
                Name= "Человек-паук: Нет пути", 
                OriginalName="Spider-Man: There is no Way"
            },
            new ModelListView() {
                Image = "/Resources/Image/logo_1.jpg",
                Name= "Человек-паук: Нет пути", 
                OriginalName="Spider-Man: There is no Way"
            },
            new ModelListView() {
                Image = "/Resources/Image/logo_1.jpg",
                Name= "Человек-паук: Нет пути", 
                OriginalName="Spider-Man: There is no Way"
            },
            new ModelListView() {
                Image = "/Resources/Image/logo_2.jpg",
                Name= "Аватар 2: Путь воды",
                OriginalName="Avatar 2: The Way of Water"
            },
            new ModelListView() {
                Image = "/Resources/Image/logo_2.jpg",
                Name= "Аватар 2: Путь воды",
                OriginalName="Avatar 2: The Way of Water"
            },
         };
    }
}
