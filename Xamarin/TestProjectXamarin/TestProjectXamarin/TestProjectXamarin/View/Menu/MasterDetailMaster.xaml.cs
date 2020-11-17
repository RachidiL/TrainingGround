using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestProjectXamarin.Model;
using TestProjectXamarin.View.DetailViews;
using TestProjectXamarin.View.DetailViews.SettingsViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestProjectXamarin.View.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailMaster()
        {
            InitializeComponent();

            var mainMenuItem = new MainMenuItem();
            mainMenuItem.MenuItems = new ObservableCollection<MainMenuItem>(new[]
            {
                 new MainMenuItem{Id = 0, Title = "MasterDetailDetail" , BackgroundColor = Color.White, TargetType = typeof(MasterDetailDetail)},
                new MainMenuItem{Id = 1, Title = "Infoscreen1" , BackgroundColor = Color.White, TargetType = typeof(InfoScreen)},
                new MainMenuItem{Id = 2, Title = "Settings" , BackgroundColor = Color.White, TargetType = typeof(SettingsScreen)}
            }); 
            BindingContext = mainMenuItem;
            ListView = MenuItemsListView;
        }

        //class MasterDetailMasterViewModel : INotifyPropertyChanged
        //{
        //    public ObservableCollection<MasterDetailMasterMenuItem> MenuItems { get; set; }

        //    public MasterDetailMasterViewModel()
        //    {
        //        MenuItems = new ObservableCollection<MasterDetailMasterMenuItem>(new[]
        //        {
        //            new MasterDetailMasterMenuItem { Id = 0, Title = "Page 1" },
        //            new MasterDetailMasterMenuItem { Id = 1, Title = "Page 2" },
        //            new MasterDetailMasterMenuItem { Id = 2, Title = "Page 3" },
        //            new MasterDetailMasterMenuItem { Id = 3, Title = "Page 4" },
        //            new MasterDetailMasterMenuItem { Id = 4, Title = "Page 5" },
        //        });
        //    }

        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}
    }
}