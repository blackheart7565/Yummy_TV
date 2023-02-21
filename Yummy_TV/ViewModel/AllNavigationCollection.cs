using System.Collections.ObjectModel;
using Yummy_TV.Model;

namespace Yummy_TV.ViewModel {
    public class AllNavigationCollection {
        public ObservableCollection<ModelListView>? AllListCollection { get; set; } = new ObservableCollection<ModelListView>(){
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
                   Name= "Мира",
                   OriginalName="The World"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_1.jpg",
                   Name= "Начало",
                   OriginalName="The Beginning"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_1.jpg",
                   Name= "Назад в будущее 3",
                   OriginalName="Back to the Future 3"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_1.jpg",
                   Name= "Матрица",
                   OriginalName="The Matrix"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Я - легенда",
                   OriginalName="I am Legend"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Джуманджи",
                   OriginalName="Jumanji"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Веном",
                   OriginalName="Venom"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Грань будущего",
                   OriginalName="The Edge of the Future"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Время",
                   OriginalName="Time"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Чужой",
                   OriginalName="Alien"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Трансформеры",
                   OriginalName="Transformers"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Сонная лощина",
                   OriginalName="Sleepy Hollow"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Первому игроку приготовиться",
                   OriginalName="First player get ready"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Я, робот",
                   OriginalName="I, the robot"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Доктор Стрэндж: В мультивселенной безумия",
                   OriginalName="Doctor Strange: In the Multiverse of Madness"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Исходный код",
                   OriginalName="Source code"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Аквамен",
                   OriginalName="Aquaman"
               },
               new ModelListView() {
                   Image = "/Resources/Image/logo_2.jpg",
                   Name= "Эквилибриум",
                   OriginalName="Equilibrium"
               },
        };
        public ObservableCollection<ModelListView>? ViewMomentCollection { get; set; } = new ObservableCollection<ModelListView>();
        public ObservableCollection<ModelListView>? ViewPlansCollection { get; set; } = new ObservableCollection<ModelListView>();
        public ObservableCollection<ModelListView>? ViewedCollection { get; set; } = new ObservableCollection<ModelListView>();
        public ObservableCollection<ModelListView>? FavouriteCollection { get; set; } = new ObservableCollection<ModelListView>();
    }
}
