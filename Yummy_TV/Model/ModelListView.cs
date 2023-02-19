using System;
using Yummy_TV.Core;

namespace Yummy_TV.Model {
    public class ModelListView : PropertyChangedBase {

        private byte[] _imgae;
        private string _name = "";
        private string _originalName = "";
        private int _released;
        private int _genre;

        public DateTime Date { get; set; } = DateTime.Now;

        public byte[] Image {
            get => _imgae;
            set => Set(ref _imgae, value, nameof(_imgae));
        }

        public string Name {
            get => _name;
            set => Set(ref _name, value, nameof(_name));
        }

        public string OriginalName {
            get => _originalName;
            set => Set(ref _originalName, value, nameof(_originalName));
        }

        public int Released {
            get => _released;
            set => Set(ref _released, value, nameof(_released));
        }

        public int Genre {
            get => _genre;
            set => Set(ref _genre, value, nameof(_genre));
        }
    }
}
