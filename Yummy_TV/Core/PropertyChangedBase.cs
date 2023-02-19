using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yummy_TV.Core {
    public class PropertyChangedBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyString = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyString));
        }

        protected virtual bool Set<T>(ref T field, T values, [CallerMemberName] string propertyString = "") {
            if (Equals(field, values)) return false;
            field = values;
            OnPropertyChanged(propertyString); return true;
        }
    }
}
