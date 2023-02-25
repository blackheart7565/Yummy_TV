using System;
using System.Windows.Input;

namespace Yummy_TV.Core {
    public class RelayCommand : ICommand {

        private Action<object>? _execute;
        private Func<object, bool> ?_canExecute; 

        public event EventHandler? CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        #region Constructor

        public RelayCommand(Action<object> execute) {
            _execute = execute;
            _canExecute = null;
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute) {
            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion

        public bool CanExecute(object? parameter) {
            return _canExecute == null ? true : _canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter) {
            _execute?.Invoke(parameter);
        }
    }
}
