using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yummy_TV.Model;

namespace Yummy_TV.Core {
    public class SerializerToJson {

        private readonly string PATH;
        string pathDir = $"{Environment.CurrentDirectory}\\config";

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path"></param>
        public SerializerToJson() { }
        public SerializerToJson(string nameFile) {

            if (Directory.Exists(pathDir)) {
                PATH = $"{pathDir}\\{nameFile}.json";

                if (File.Exists(PATH)) {
                    List<string> arrFile = new List<string>();
                    using (FileStream fileStream = new FileStream(PATH, FileMode.Open)) {
                        using (StreamReader reader = new StreamReader(fileStream)) {
                            arrFile.Add(reader.ReadToEnd());
                        }
                        if (arrFile[0] == "") {
                            File.Delete(PATH);
                            arrFile.Clear();
                        }
                        else {
                            arrFile.Clear();
                        }
                    }
                }
            }
            else {
                Directory.CreateDirectory(pathDir);
                PATH = $"{pathDir}\\{nameFile}.json";
            }
        }

        /// <summary>
        /// Загрузка из json-файл
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<ModelListView> LoadFileJson() {
            //проверяем сощуствует ли файл
            var isFileExist = File.Exists(PATH);
            if (!isFileExist) {

                //освобождам ресурсы и создаем или открываем файл
                File.CreateText(PATH).Dispose();

                //возращаем новый обьект лист-model
                return new ObservableCollection<ModelListView>();
            }

            //открываем и считываем файл в поток
            using (var reader = File.OpenText(PATH)) {

                //считываем все строки пока не конец файла
                var fileTestReader = reader.ReadToEnd();

                //возращаем десириализованый обьект из строк
                return JsonConvert.DeserializeObject<ObservableCollection<ModelListView>>(fileTestReader);
            }
        }

        public void SaveFIleJson(object? modelNotepads, string nameFile) {

            //считываем в поток созданый или открытый файл
            using (StreamWriter writer = File.CreateText($"{pathDir}\\{nameFile}.json")) {

                //сериализируем лист-модели в json-файл
                string outPut = JsonConvert.SerializeObject(modelNotepads);

                //запись сериализированой строки в созданый поток из файла
                writer.Write(outPut);
            }
        }

    }
}
