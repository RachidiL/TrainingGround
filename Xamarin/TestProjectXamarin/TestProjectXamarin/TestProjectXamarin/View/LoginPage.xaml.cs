using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectXamarin.Model;
using TestProjectXamarin.View.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TestProjectXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            usernameLabel.TextColor = Constants.MainTextColor;
            passwordLabel.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            App.StartCheckInternetConnection(NoInternetLabel, this);

            usernameEntry.Completed += (s,e) => passwordEntry.Focus();
            passwordEntry.Completed += (s, e) => SignInButton_Clicked(s, e);
        }

        private async void SignInButton_Clicked(object sender, EventArgs e)
        {
            User user = new User(usernameEntry.Text, passwordEntry.Text);

            if (user.CheckInformation())
            {
                ActivitySpinner.IsVisible = true;
                //var result = await App.RestService.Login(user);
                var result = new Token();

                await DisplayAlert("Login", "Login Success.", "Ok");
                
                if (result != null)
                {
                    ActivitySpinner.IsVisible = false;
                    //App.UserDatabase.SaveUser(user);
                    //App.TokenDatabase.SaveToken(result);
                    //await Navigation.PushAsync(new Dashboard());
                    if (Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new MasterDetail());
                    }
                    else if(Device.RuntimePlatform == Device.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new MasterDetail()));
                    }
                }
            }
            else
            {
                await DisplayAlert("Login", "Login Not Correct, empty username or password", "Ok");
                ActivitySpinner.IsVisible = false;
            }
        }
    }
}