using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Yummy_TV.Core;

namespace Yummy_TV.ViewModel {
    public class MainNavigationVM : PropertyChangedBase {

        #region Margin

        private PropertyChangedBase _changedBase;
        private string _information = "";

        #endregion

        #region Property
        
        public PropertyChangedBase ChangedBase {
            get => _changedBase;
            set => Set(ref _changedBase, value, nameof(ChangedBase));
        }

        public string Information {
            get => _information;
            set => Set(ref _information, value, nameof(Information));
        }

        #endregion


        /// <summary>
        /// Property Command
        /// </summary>
        public ICommand ButtonClose { get; }
        public ICommand ShowHomeCommand { get; }
        public ICommand ShowFullListCommand { get; }
        public ICommand ShowViewMomentCommand { get; }
        public ICommand ShowViewPlansCommand { get; }
        public ICommand ShowViewedCommand { get; }
        public ICommand ShowFavouriteCommand { get; }



        /// <summary>
        /// Constructor
        /// </summary>
        #pragma warning disable CS8618
        public MainNavigationVM() {
            ButtonClose = new RelayCommand((obj) => Application.Current.Shutdown());
            ShowHomeCommand = new RelayCommand(ExecuteShowHomeCommand);
            ShowFullListCommand = new RelayCommand(ExecuteShowFullListCommand);
            ShowViewMomentCommand = new RelayCommand(ExecuteShowViewMomentCommand);
            ShowViewPlansCommand = new RelayCommand(ExecuteShowViewPlansCommand);
            ShowViewedCommand = new RelayCommand(ExecuteShowViewedCommand);
            ShowFavouriteCommand = new RelayCommand(ExecuteShowFavouriteCommand);

            ExecuteShowHomeCommand(null);
        }
        #pragma warning restore CS8618


        /// <summary>
        /// Mathods
        /// </summary>
        /// <param name="obj"></param>
        private void ExecuteShowHomeCommand(object? obj) {
            ChangedBase = new HomeVM();
            Information = "Главная";
        }
        private void ExecuteShowFullListCommand(object? obj) {
            ChangedBase = new FullListVM();
            Information = "Полный список";
        }
        private void ExecuteShowViewMomentCommand(object obj) {
            ChangedBase = new ViewMomentVM();
            Information = "Смотрю в данный момент";
        }
        private void ExecuteShowViewPlansCommand(object obj) {
            ChangedBase = new ViewPlansVM();
            Information = "В планах";
        }
        private void ExecuteShowViewedCommand(object obj) {
            ChangedBase = new ViewedVM();
            Information = "Прочитано";
        }
        private void ExecuteShowFavouriteCommand(object obj) {
            ChangedBase = new FavouriteVM();
            Information = "Любимые";
        }
    }
}
