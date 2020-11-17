using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectXamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestProjectXamarin.View.DetailViews.SettingsViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsScreen : ContentPage
    {
        Settings settings;
        SwitchCell switchcell1;
        SwitchCell switchcell2;
        //dffdUser currentUser;
        public SettingsScreen()
        {
            InitializeComponent();
            BackgroundColor = Constants.BackgroundColor;
            LoadSettigs();
            App.StartCheckInternetConnection(NoInternetLbl, this);
            Title = Constants.SettingsScreenTitle;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.StartCheckInternetConnection(NoInternetLbl, this);
        }

        private void LoadSettigs()
        {
            settings = App.SettingsDatabase.GetSettings();
            //currentUser = App.UserDatabase.GetUser();

            switchcell1 = new SwitchCell
            {
                Text = "SwitchCell 1",
                On = settings.Switch1
            };
            switchcell1.OnChanged += (object sender, ToggledEventArgs e) =>
            {
                SwitchCell1Switched(sender, e);
            };

            switchcell2 = new SwitchCell
            {
                Text = "SwitchCell 2",
                On = settings.Switch2
            };
            switchcell2.OnChanged += (object sender, ToggledEventArgs e) =>
            {
                SwitchCell2Switched(sender, e);
            };

            TableView table = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection
                    {
                        switchcell1,
                        switchcell2
                    }
                }
            };
            table.VerticalOptions = LayoutOptions.FillAndExpand;
            MainLayout.Children.Add(table);
        }

        private void SwitchCell2Switched(object sender, ToggledEventArgs e)
        {
            settings.Switch2 = e.Value;
        }

        private void SwitchCell1Switched(object sender, ToggledEventArgs e)
        {
            settings.Switch1 = e.Value;
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            var action = await DisplayAlert("Settings", "Do you wnat to save the settings?", "Ok", "Cancel");
            if(action)
                SaveSettings();
        }

        private void SaveSettings()
        {
            App.SettingsDatabase.SaveSettings(settings);
        }
    }
}