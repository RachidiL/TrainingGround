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
            InitSearchBar();
        }

        private void InitSearchBar()
        {
            searchBar.TextChanged += (s, e) => FilterItem(searchBar.Text);
            searchBar.SearchButtonPressed += (s, e) => FilterItem(searchBar.Text);
        }

        private void FilterItem(string filter)
        {
            listViewExample.BeginRefresh();
            if(string.IsNullOrWhiteSpace(filter))
            {
                listViewExample.ItemsSource = Items;
            }
            else
            {
                listViewExample.ItemsSource = Items.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
            }
            listViewExample.EndRefresh();
        }

        private void InitList()
        {
            Items = new List<ListViewItem>();
            Items.Add(new ListViewItem { 
                Name = "abc",
                Value = 10,
                Text = "Blablabla This is View 1"});
            Items.Add(new ListViewItem
            {
                Name = "bca",
                Value = 15,
                Text = "Blablabla this is View 2"
            });
            Items.Add(new ListViewItem
            {
                Name = "cab",
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

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Toolbar", "Cancel Button", "Ok");
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Toolbar", "Save Button", "Ok");
            List<string> buttons = new List<string>
            {
                "Button1",
                "Button2",
                "Button3"
            };
            var reaction = await DisplayActionSheet("Title", "Cancel", "Ok", buttons.ToArray());

            switch (reaction)
            {
                case "Button1":
                    await DisplayAlert("DisplayActionSheet", "Button1", "Ok");
                    break;
                case "Button2":
                    await DisplayAlert("DisplayActionSheet", "Button2", "Ok");
                    break;
                case "Button3":
                    await DisplayAlert("DisplayActionSheet", "Button3", "Ok");
                    break;
            }
        }

        private void Settings_Clicked(object sender, EventArgs e)
        {

        }
    }
}
