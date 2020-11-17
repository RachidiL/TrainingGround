using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestProjectXamarin.View.DetailViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoScreen : ContentPage
    {
        public InfoScreen()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            ActivitySpinner.IsVisible = true;
        }
    }
}