using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace TestProjectXamarin.Model
{
    public class MainMenuItem : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Color BackgroundColor { get; set; }
        public Type TargetType { get; set; }

        public ObservableCollection<MainMenuItem> MenuItems { get; set; }

        public MainMenuItem()
        {

        }

        //public MainMenuItem(string title, string iconSource, Color backgroundColor, Type targetType)
        //{
        //    Title = title;
        //    IconSource = iconSource;
        //    BackgroundColor = backgroundColor;
        //    TargetType = targetType;
        //}

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
