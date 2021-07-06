using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SystemReinstallCopier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static DependencyProperty ViewModelProperty = DependencyProperty.Register(nameof(ViewModel), typeof(ViewModel), typeof(MainWindow));
        public ViewModel ViewModel
        {
            get
            {
                return (ViewModel)GetValue(ViewModelProperty);
            }
            set
            {
                SetValue(ViewModelProperty, value);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            Test();
        }

        private void Test()
        {
            ViewModel = new ViewModel()
            {
                Configuration = new SRCConfiguration()
                {
                    SavedDirectories = new List<DirectoryInfo>
                    {
                        new DirectoryInfo("123"),
                        new DirectoryInfo("321")
                    }
                },
                SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
        }

        private void SelectSaveFolder(object sender, RoutedEventArgs e)
        {
            new SelectFolderDialog(ViewModel.SaveFolder, true, path =>
            {
                ViewModel.SaveFolder = path;
            }).Show();
        }
    }
}
