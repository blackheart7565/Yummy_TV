using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yummy_TV.Core;

namespace Yummy_TV.ViewModel {
    public class MainNavigationVM : PropertyChangedBase {

        private PropertyChangedBase _changedBase;
        private string _information;

        public PropertyChangedBase ChangedBase {
            get => _changedBase;
            set => Set(ref _changedBase, value, nameof(_changedBase));
        }

        public string Information {
            get => _information;
            set => Set(ref _information, value, _information);
        }





    }
}
