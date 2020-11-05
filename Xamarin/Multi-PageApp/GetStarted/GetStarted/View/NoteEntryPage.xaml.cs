using GetStarted.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GetStarted.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        private async void deleteButton_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (File.Exists(note.FileName))
                File.Delete(note.FileName);

            await Navigation.PopAsync();
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            if (string.IsNullOrWhiteSpace(note.FileName))
            {
                var fileName = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.text");
                File.WriteAllText(fileName, note.Text);
            }
            else
                File.WriteAllText(note.FileName, note.Text);

            await Navigation.PopAsync();
        }
    }
}