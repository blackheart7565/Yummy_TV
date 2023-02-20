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
        private string _information;

        #endregion

        #region Property
        
        public PropertyChangedBase ChangedBase {
            get => _changedBase;
            set => Set(ref _changedBase, value, nameof(_changedBase));
        }

        public string Information {
            get => _information;
            set => Set(ref _information, value, _information);
        }

        #endregion

        /// <summary>
        /// Property Command
        /// </summary>
        public ICommand ButtonClose { get; }
        public ICommand ShowSettings { get; }
        public ICommand ShowFullList { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MainNavigationVM() {
            ButtonClose = new RelayCommand((obj) => Application.Current.Shutdown());
            ShowFullList = new RelayCommand(ExecuteShowFullListCommand);
            ShowSettings = new RelayCommand(ExecuteShowSettingsCommand);


            ExecuteShowFullListCommand(null);

        }

        /// <summary>
        /// Mathods
        /// </summary>
        /// <param name="obj"></param>
        private void ExecuteShowFullListCommand(object obj) {
            ChangedBase = new FullListVM();
            Information = "Полный список";
        }
        private void ExecuteShowSettingsCommand(object obj) {
            AddToFilter addToList = new();
            addToList.ShowDialog();
        }
    }
}
