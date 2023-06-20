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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace WPFTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Default Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region On Loaded
        /// <summary>
        /// Se carga cuando la aplicación se inicia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Coge lo de dispositivos y unidades en mi equipo
            foreach (var drive in Directory.GetLogicalDrives())
            {
                //Crea un nuevo item para cada uno
                var item = new TreeViewItem()
                {
                    //Asigna Header 
                    Header = drive,
                    //Asigna Full Path
                    Tag = drive
                };

                //prueba? Dummy data
                item.Items.Add(null);

                //Expansion de item
                item.Expanded += Folder_Expanded;


                //Lo agrega a la vista
                FolderView.Items.Add(item);
            }
        }

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            #region Initial Checks
            var item =(TreeViewItem)sender;

            //If the item only contains dummy data
            if (item.Items.Count != 1 || item.Items[0] != null) return;

            //Clear dummy data
            item.Items.Clear();

            //Get full path name
            var fullPath = (string)item.Tag;
            #endregion

            #region Get Directories
            //Create a Blank list for directories
            var directories =new List<string>();

            //Try and get directories from the folder ignoring any issues
            try
            {
                var dirs=Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                {
                    directories.AddRange(dirs);    
                }
            }
            catch {}

            //Foreach directory...
            directories.ForEach(directoryPath =>
            {
                //Create directory item 
                var subItem = new TreeViewItem()
                {
                    // Asignar Header as folder name
                    Header = GetFileFolderName(directoryPath),

                    //Asignar Tag as full path
                    Tag= directoryPath
                };

                //Add dummy item so we can expand the folder
                subItem.Items.Add(null);

                //Handle expanding
                subItem.Expanded += Folder_Expanded;

                //Add this item to parent
                item.Items.Add(subItem);
            });
            #endregion

            #region Get Files
            //Create a Blank list for files
            var files = new List<string>();

            //Try and get files from the folder ignoring any issues
            try
            {
                var fs = Directory.GetFiles(fullPath);
                if (fs.Length > 0)
                {
                    files.AddRange(fs);
                }
            }
            catch { }

            //Foreach file...
            files.ForEach(filePath =>
            {
                //Create file item 
                var subItem = new TreeViewItem()
                {
                    // Asignar Header as file name
                    Header = GetFileFolderName(filePath),

                    //Asignar Tag as full path
                    Tag = filePath
                };


                //Add this item to parent
                item.Items.Add(subItem);
            });
            #endregion
        }
        #endregion

        #region Helpers
        /// <summary>
        /// Find the file o folder name from a full path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFileFolderName(string path)
        {
            //If we have no path return empty
            if (string.IsNullOrEmpty(path)) return string.Empty;

            //Make all slashes back slashes
            var normalizepath = path.Replace("/", "\\");

            //Find the last backslash
            var lastIndex= normalizepath.LastIndexOf('\\');

            //Si no encontramos backslash retornar path igual
            if (lastIndex <= 0) return path;

            //Return the name after the last backslash
            return path.Substring(lastIndex+1);
        }
        #endregion
    }
}
