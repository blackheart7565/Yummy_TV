using System.Linq;
using System.Windows;
using Yummy_TV.Core;
using Yummy_TV.View;

namespace Yummy_TV.ViewModel {
    public class AddToFilterVM {

        private SerializerToJson? serializerToJson;

        private RelayCommand<Window>? _windowDragMoveCommand;
        private RelayCommand<Window>? _closeWindow;
        private RelayCommand<int>? _saveToListCommand;

        #region Все команды (All Command)

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
        /// Перемещение окна
        /// </summary>
        public RelayCommand<Window> WindowDragMoveCommand {
            get {
                return _windowDragMoveCommand ??= new RelayCommand<Window>(obj => {
                    obj.DragMove();
                });
            }
        }
        /// <summary>
        /// Созранение в указаные списки
        /// </summary>
        public RelayCommand<int> SaveToListCommand {
            get {
                return _saveToListCommand ??= new RelayCommand<int>(obj => {
                    switch (obj) {
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
                                    serializerToJson.SaveFIleJson(AllNavigationCollection.FavouriteCollection, "FavouriteListJson");
                                }
                            }
                            break;
                    }
                });
            }
        }

        #endregion

    }
}
