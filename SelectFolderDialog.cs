using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemReinstallCopier
{
    public class SelectFolderDialog
    {
        private CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        private Action<string> onSuccess;

        public SelectFolderDialog(string initialDirectory = "",bool useForFolders=false,Action<string> onSuccess=null)
        {
            dialog.InitialDirectory = initialDirectory;
            dialog.IsFolderPicker = useForFolders;
            this.onSuccess = onSuccess;
        }

        public void Show()
        {
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                onSuccess?.Invoke(dialog.FileName);
            }
        }
    }
}
