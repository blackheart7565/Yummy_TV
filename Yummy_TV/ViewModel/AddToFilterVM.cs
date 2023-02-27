using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Yummy_TV.Core;
using Yummy_TV.Model;
using Yummy_TV.View;

namespace Yummy_TV.ViewModel {
    public class AddToFilterVM {

        private string mameTemp = "";
        private string originalNameTemp = "";

        private SerializerToJson? serializerToJson;

        private RelayCommand<Window>? _windowDragMoveCommand;
        private RelayCommand<Window>? _closeWindow;
        private RelayCommand<int>? _saveToListCommand;
        private RelayCommand? _removeToList;

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

                                    GenerateID(AllNavigationCollection.ViewMomentCollection);

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

                                    GenerateID(AllNavigationCollection.ViewPlansCollection);

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

                                    GenerateID(AllNavigationCollection.ViewedCollection);

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

                                    GenerateID(AllNavigationCollection.FavouriteCollection);

                                    serializerToJson = new SerializerToJson();
                                    serializerToJson.SaveFIleJson(AllNavigationCollection.FavouriteCollection, "FavouriteListJson");
                                }
                            }
                            break;
                    }
                });
            }
        }
        /// <summary>
        /// Удаление из списка
        /// </summary>
        public RelayCommand? RemoveToList {
            get {
                return _removeToList ??= new RelayCommand(obj => {
                    serializerToJson = new SerializerToJson();

                    mameTemp = AllNavigationCollection.AllListCollection[FullListUS.Index].Name;
                    originalNameTemp = AllNavigationCollection.AllListCollection[FullListUS.Index].OriginalName;

                    RemoveElementList(AllNavigationCollection.AllListCollection, "FullListJson");
                    RemoveElementList(AllNavigationCollection.ViewMomentCollection, "ViewMomentListJson");
                    RemoveElementList(AllNavigationCollection.ViewPlansCollection, "ViewPlansListJson");
                    RemoveElementList(AllNavigationCollection.ViewedCollection, "ViewedListJson");
                    RemoveElementList(AllNavigationCollection.FavouriteCollection, "FavouriteListJson");
                });
            }
        }

        #endregion

        #region All Method

        /// <summary>
        /// Проверка на совместимость ID колекции.
        /// </summary>
        /// <param name="collectionModels"></param>
        /// <returns> Возвращяет true если ID равняется индексу, иначе false </returns>
        private bool IsCheckIndexList(ObservableCollection<ModelListView> collectionModels) {
            if (collectionModels.Any(all => all.Name == collectionModels[FullListUS.Index].Name &&
                                            all.OriginalName == collectionModels[FullListUS.Index].OriginalName)) {
                return true;
            }
            else {
                return false;
            }
        }
        /// <summary>
        /// Перегенерация Айди
        /// </summary>
        /// <param name="collectionModel"></param>
        private void GenerateID(ObservableCollection<ModelListView> collectionModel) {
            for (int i = 0; i < collectionModel.Count; i++) {
                collectionModel[i].ID = i;
            }
        }
        /// <summary>
        /// Удаление елемента колекции
        /// </summary>
        /// <param name="collectionModel"></param>
        private void RemoveElementList(ObservableCollection<ModelListView> collectionModel, string nameFileJson) {

           List<int> indx =  collectionModel.Where(c => c.Name == mameTemp &&
                                                            c.OriginalName == originalNameTemp)
                                            .Select(x=> x.ID).ToList();
            if (indx.Count > 0) {
                collectionModel.RemoveAt(indx[0]);
                GenerateID(collectionModel);
                serializerToJson?.SaveFIleJson(collectionModel, nameFileJson);
            }            
        }

        #endregion

    }
}
