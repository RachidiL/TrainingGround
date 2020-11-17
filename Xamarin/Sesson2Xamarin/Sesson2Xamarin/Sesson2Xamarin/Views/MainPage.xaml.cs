using Sesson2Xamarin.Models;
using Sesson2Xamarin.Views;
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
                Text = "Blablabla This is View 1"});
            Items.Add(new ListViewItem
            {
                Name = "Test2",
                Value = 15,
                Text = "Blablabla this is View 2"
            });
            Items.Add(new ListViewItem
            {
                Name = "Test3",
                Value = 20,
                Text = "Blablabla this is View 3"
            });
            listViewExample.ItemsSource = Items;
            listViewExample.ItemTapped += ListViewExample_ItemTapped;
        }

        private void ListViewExample_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Item;
            Navigation.PushAsync( new DetailView(item));
        }
    }
}
