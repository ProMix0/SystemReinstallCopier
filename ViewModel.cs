using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SystemReinstallCopier
{
    public class ViewModel : DependencyObject
    {
        public static DependencyProperty SaveFolderProperty = DependencyProperty.Register(nameof(SaveFolder), typeof(string), typeof(ViewModel));

        public SRCConfiguration Configuration { get; set; }
        public string SaveFolder
        {
            get
            {
                return (string)GetValue(SaveFolderProperty);
            }
            set
            {
                SetValue(SaveFolderProperty, value);
            }
        }
    }
}
