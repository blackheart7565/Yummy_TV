using Yummy_TV.Core;

namespace Yummy_TV.ViewModel {
    public class MainNavigationVM : PropertyChangedBase {

        private RelayCommand? _buttonShutdown;
        private RelayCommand? _showHomeCommand;
        private RelayCommand? _showFullListCommand;
        private RelayCommand? _showViewMomentCommand;
        private RelayCommand? _showViewPlansCommand;
        private RelayCommand? _showViewedCommand;
        private RelayCommand? _showFavouriteCommand;
        private RelayCommand? _showSettingsCommand;
        private RelayCommand? _showRenameAllFileToFoldeCommand;

        private PropertyChangedBase? _changedBase;

        private string _information = "";


        public MainNavigationVM() {
            ExecuteShowHomeCommand();
        }

        #region Property

        public PropertyChangedBase? ChangedBase {
            get => _changedBase;
            set => Set(ref _changedBase, value, nameof(ChangedBase));
        }

        public string Information {
            get => _information;
            set => Set(ref _information, value, nameof(Information));
        }

        #endregion

        #region Все команды (All Command)

        /// <summary>
        /// Закрытие всех оконых потоков
        /// </summary>
        public RelayCommand ButtonShutdown {
            get {
                return _buttonShutdown ??= new RelayCommand(obj => {
                    System.Windows.Application.Current.Shutdown();
                });
            }
        }
        /// <summary>
        /// Главное окно
        /// </summary>
        public RelayCommand ShowHomeCommand {
            get {
                return _showHomeCommand ??= new RelayCommand(obj => {
                    ChangedBase = new HomeVM();
                    Information = "Главная";
                });
            }
        }
        /// <summary>
        /// Полный список
        /// </summary>
        public RelayCommand ShowFullListCommand {
            get {
                return _showFullListCommand ??= new RelayCommand(obj => {
                    ChangedBase = new FullListVM();
                    Information = "Полный список";
                });
            }
        }
        /// <summary>
        /// Смотрю в данный момент
        /// </summary>
        public RelayCommand ShowViewMomentCommand {
            get {
                return _showViewMomentCommand ??= new RelayCommand(obj => {
                    ChangedBase = new ViewMomentVM();
                    Information = "Смотрю в данный момент";
                });
            }
        }
        /// <summary>
        /// В планах
        /// </summary>
        public RelayCommand ShowViewPlansCommand {
            get {
                return _showViewPlansCommand ??= new RelayCommand(obj => {
                    ChangedBase = new ViewPlansVM();
                    Information = "В планах";
                });
            }
        }
        /// <summary>
        /// Просмотрено
        /// </summary>
        public RelayCommand ShowViewedCommand {
            get {
                return _showViewedCommand ??= new RelayCommand(obj => {
                    ChangedBase = new ViewedVM();
                    Information = "Прочитано";
                });
            }
        }
        /// <summary>
        /// Любимые
        /// </summary>
        public RelayCommand ShowFavouriteCommand {
            get {
                return _showFavouriteCommand ??= new RelayCommand(obj => {
                    ChangedBase = new FavouriteVM();
                    Information = "Любимые";
                });
            }
        }
        /// <summary>
        /// Настройки
        /// </summary>
        public RelayCommand ShowSettingsCommand {
            get {
                return _showSettingsCommand ??= new RelayCommand(obj => {
                    ChangedBase = new SettingsVM();
                    Information = "Настройки";
                });
            }
        }
        /// <summary>
        /// Настройки
        /// </summary>
        public RelayCommand ShowRenameAllFileToFoldeCommand {
            get {
                return _showSettingsCommand ??= new RelayCommand(obj => {
                    ChangedBase = new RenameAllFileToFolderVm();
                    Information = "Переименовка файлов";
                });
            }
        }

       

        #endregion

        #region Methods

        /// <summary>
        /// Первое отображение главного окна
        /// </summary>
        private void ExecuteShowHomeCommand() {
            ChangedBase = new HomeVM();
            Information = "Главная";
        }

        #endregion

    }
}
