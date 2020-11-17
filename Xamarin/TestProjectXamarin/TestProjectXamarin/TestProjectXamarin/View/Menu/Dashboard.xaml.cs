using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectXamarin.Model;
using TestProjectXamarin.View.DetailViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestProjectXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            App.StartCheckInternetConnection(NoInternetLabel, this);
        }
        private async void ScreenOne_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoScreen());
        }
    }
}