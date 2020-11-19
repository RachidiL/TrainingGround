using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JSONConverter.Model
{
    class JSONData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _jsonContent = "JSON File";
        public string JSONContent 
        {
            get { return _jsonContent; }
            set
            {
                _jsonContent = value;
                OnPropertyChanged();
            }
        }
    }
}
