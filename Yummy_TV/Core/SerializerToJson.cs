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

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="path"></param>
        public SerializerToJson(string nameFile) {
            string pathDir = $"{Environment.CurrentDirectory}\\config";

            if (Directory.Exists(pathDir)) {
                PATH = $"{pathDir}\\{nameFile}.json";
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

        /// <summary>
        /// Сохранение в json-файл
        /// </summary>
        public void SaveFIleJson(object? modelNotepads) {

            //считываем в поток созданый или открытый файл
            using (StreamWriter writer = File.CreateText(PATH)) {

                //сериализируем лист-модели в json-файл
                string outPut = JsonConvert.SerializeObject(modelNotepads);

                //запись сериализированой строки в созданый поток из файла
                writer.Write(outPut);
            }
        }


    }
}
