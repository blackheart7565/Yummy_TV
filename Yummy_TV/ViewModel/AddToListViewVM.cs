using System.Windows;
using Yummy_TV.Core;
using Yummy_TV.View;

namespace Yummy_TV.ViewModel {
    public class AddToListViewVM : PropertyChangedBase {

        private SerializerToJson serializerToJson = new SerializerToJson();

        private RelayCommand<Window>? _closeWindow;
        private RelayCommand<Window>? _windowDragMode;
        private RelayCommand<Window>? _buttonAddToListBox;

        #region Все команды (All Commands)

        /// <summary>
        /// Закрытие окна
        /// </summary>
        public RelayCommand<Window> CloseWindow {
            get {
                return _closeWindow ??= new RelayCommand<Window>(win => {
                    win.Close();
                });
            }
        }
        /// <summary>
        /// Перемещения окна
        /// </summary>
        public RelayCommand<Window> WindowDragMove {
            get {
                return _windowDragMode ??= new RelayCommand<Window>(win => {
                    win.DragMove();
                });
            }
        }
        /// <summary>
        /// Добавление элемента в общий список
        /// </summary>
        public RelayCommand<Window> ButtonAddToListBox {
            get {
                return _buttonAddToListBox ??= new RelayCommand<Window>(obj => {
                    AddToListView? win = obj as AddToListView;
                    AllNavigationCollection.AllListCollection.Add(
                                            new Model.ModelListView(
                                                win.textBoxName.Text,
                                                win.textBoxOriginalName.Text
                                                )
                                            );
                    for (int i = 0; i < AllNavigationCollection.AllListCollection.Count; i++) {
                        AllNavigationCollection.AllListCollection[i].ID = i;
                    }
                    win.Close();

                    serializerToJson.SaveFIleJson(AllNavigationCollection.AllListCollection, "FullListJson");
                });
            }
        }

        #endregion

    }
}
