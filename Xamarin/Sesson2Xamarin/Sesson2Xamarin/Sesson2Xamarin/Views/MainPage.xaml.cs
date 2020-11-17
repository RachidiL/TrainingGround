using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sesson2Xamarin
{
    public partial class MainPage : ContentPage
    {
        List<string> Items;
        public MainPage()
        {
            InitializeComponent();
            InitList();
        }

        private void InitList()
        {
            Items = new List<string>();
            Items.Add("Item1");
            Items.Add("Item2");
            Items.Add("Item3");
            listViewExample.ItemsSource = Items;
        }
    }
}
