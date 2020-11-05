using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestProjectXamarin.Model
{
    public class Constants
    {
        public static bool IsDev = true;

        public static Color BackgroundColor = Color.Transparent; //Color.FromRgb(58, 153, 215);

        public static Color MainTextColor = Color.White;

        public static int LoginIconHeight { get; internal set; } = 120;


        //----------LogIn----------------///
        public static string LoginUrl = "https://test.com/api/Auth/login";
        public static string NoInternetText { get; internal set; } = "No Internet, please reconnect";
    }
}
