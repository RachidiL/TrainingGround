
using Android.App;
using Android.Content;
using Android.Net;
using TestProjectXamarin.Data;
using TestProjectXamarin.Droid.Data;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]

namespace TestProjectXamarin.Droid.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; private set; }

        public void CheckNetworkConnection()
        {
            var connectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            var activeNetworkInfo = connectivityManager.ActiveNetworkInfo;
            IsConnected = activeNetworkInfo != null && activeNetworkInfo.IsConnected;
        }
    }
}