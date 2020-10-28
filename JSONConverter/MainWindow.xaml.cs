using JSONConverter.Model;
using JSONConverter.ViewModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Input;

namespace JSONConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JSONData jsonData;
        public MainWindow()
        {
            InitializeComponent();
            jsonData = new JSONData();
            DataContext = jsonData;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void JSONFileDroped(object sender, DragEventArgs e)
        {
            var dataObject = e.Data as DataObject;

            if (dataObject.ContainsFileDropList())
            {
                StringCollection fileNames = dataObject.GetFileDropList();

                var jsonDataParser = new JSONDataParser(jsonData);
                jsonDataParser.ReadJSONFile(fileNames[0]);
            }

        }
    }
}
