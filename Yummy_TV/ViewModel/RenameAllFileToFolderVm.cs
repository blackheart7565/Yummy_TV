using System.IO;
using System.Windows;
using System.Windows.Controls;
using Yummy_TV.Core;

namespace Yummy_TV.ViewModel {
	public class RenameAllFileToFolderVm : PropertyChangedBase {

		private RelayCommand<TextBox>? _buttonRenameFileCommand;

        #region All Command
		
		/// <summary>
		/// Кнопка переименования
		/// </summary>
		public RelayCommand<TextBox> ButtonRenameFileCommand {
			get {
				return _buttonRenameFileCommand ??= new RelayCommand<TextBox>(obj => {
                    int i = 1;
                    string path = obj.Text;
                    foreach (var dir in Directory.GetFiles(path)) {
                        File.Move(dir, path + @"\" + i++ + Path.GetExtension(dir));
                    }
                });
			}
		}

		#endregion
	}
}
