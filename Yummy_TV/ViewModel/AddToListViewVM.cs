using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using Yummy_TV.Core;
using Yummy_TV.View;

namespace Yummy_TV.ViewModel {
    public class AddToListViewVM : PropertyChangedBase {

        private SerializerToJson serializerToJson = new SerializerToJson();

        private RelayCommand<Window>? _closeWindow;
        private RelayCommand<Window>? _windowDragMode;
        private RelayCommand<Window>? _buttonAddToListBox;
        private RelayCommand<ImageSource>? _addToListImage;

        private byte[]? _imageByte;

        #region Property

        public byte[]? ImageByte { 
            get=> _imageByte;
            set => Set(ref _imageByte, value, nameof(ImageByte));
        }

        #endregion

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
                                                ImageByte,
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
        /// <summary>
        /// Добавление картинки
        /// </summary>
        public RelayCommand<ImageSource> AddToListImage {
            get {
                return _addToListImage ??= new RelayCommand<ImageSource>(obj => {

                    System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog() {
                        Filter = "Все файлы (*.*)|*.*"
                    };
                    if (fileDialog.ShowDialog() == DialogResult.OK) {

                        using (FileStream fileStream = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read)) {
                            using (BinaryReader binaryReader = new BinaryReader(fileStream)) {
                                ImageByte = binaryReader.ReadBytes((int)fileStream.Length);
                            }
                        }
                    }
                });
            }
        }

        #endregion

    }
}
