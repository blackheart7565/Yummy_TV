using System;
using Yummy_TV.Core;
using Yummy_TV.ViewModel;

namespace Yummy_TV.Model {
    public class ModelListView : PropertyChangedBase {

        private int _id;
        private string _imgae;
        private string _name = "";
        private string _originalName = "";
        private int _released;
        private int _genre;

        public DateTime Data { get; set; } = DateTime.Now;


        public int ID {
            get => _id;
            set => Set(ref _id, value, nameof(ID));
        }
        public string Image {
            get => _imgae;
            set => Set(ref _imgae, value, nameof(Image));
        }

        public string Name {
            get => _name;
            set => Set(ref _name, value, nameof(Name));
        }

        public string OriginalName {
            get => _originalName;
            set => Set(ref _originalName, value, nameof(OriginalName));
        }

        public int Released {
            get => _released;
            set => Set(ref _released, value, nameof(Released));
        }

        public int Genre {
            get => _genre;
            set => Set(ref _genre, value, nameof(Genre));
        }

        public ModelListView() { }
        public ModelListView(string name, string originalName) {
            Name = name;
            OriginalName = originalName;
        }
        public ModelListView(string name, string originalName, int released, int genre) : this(name, originalName) {
            Released = released;
            Genre = genre;
        }
    }
}
