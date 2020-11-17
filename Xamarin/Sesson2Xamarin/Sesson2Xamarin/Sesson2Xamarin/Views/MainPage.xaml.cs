using Sesson2Xamarin.Models;
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
        List<ListViewItem> Items;
        public MainPage()
        {
            InitializeComponent();
            InitList();
        }

        private void InitList()
        {
            Items = new List<ListViewItem>();
            Items.Add(new ListViewItem { 
                Name = "Test1",
                Value = 10,
                Text = "Blablabla"});
            Items.Add(new ListViewItem
            {
                Name = "Test2",
                Value = 15,
                Text = "Blablabla"
            });
            Items.Add(new ListViewItem
            {
                Name = "Test3",
                Value = 20,
                Text = "Blablabla"
            });
            listViewExample.ItemsSource = Items;
        }
    }
}
