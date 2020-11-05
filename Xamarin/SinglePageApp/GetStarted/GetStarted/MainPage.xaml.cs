using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GetStarted.Data;

namespace GetStarted
{
    public partial class MainPage : ContentPage
    {
        private Notes InsertedNotes;
        public MainPage()
        {
            InitializeComponent();
            InsertedNotes = new Notes();
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(editField.Text))
            {
                InsertedNotes.MyNote.Add(editField.Text);
                DisplayAlert("Note entry", $"Your Note: {editField.Text} \nis saved", "Ok");
                editField.Text = null;
            }
            else
                DisplayAlert("Note entry", "Please insert a note to save!", "Ok");

        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
