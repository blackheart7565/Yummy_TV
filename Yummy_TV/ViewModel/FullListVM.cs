using System.Collections.ObjectModel;
using Yummy_TV.Core;
using Yummy_TV.Model;
using Yummy_TV.View;

namespace Yummy_TV.ViewModel {
	public class FullListVM : PropertyChangedBase {

		private RelayCommand? _showAddToListBox;

        #region All Commands

        /// <summary>
        /// Показать окно добавление новых данных в ListBox
        /// </summary>
        public RelayCommand ShowAddToListBox {
			get {
				return _showAddToListBox ??= new RelayCommand(obj => {
					AddToListView addToList = new();
					addToList.ShowDialog();
				});
			}
		}
        /// <summary>
        ///  Возвращяет Полный список внесенных данных в колекцию AllListCollection"
        /// </summary>
        public ObservableCollection<ModelListView> GetModelCollaction {
			get {
				return AllNavigationCollection.AllListCollection;
            }
		}

		#endregion

	}
}
