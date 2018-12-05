using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sahara
{
    public partial class personalInfoSettingsPage : ContentPage
    {
        public personalInfoSettingsPage()
        {
            InitializeComponent();

            FetchInfo();
        }

        private async void authButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sign In", "USER/PASSWORD box here", "OK", "Cancel");
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            var InfoStuff = new PersonalInfo
            {
                FName = firstNameEntry.Text,
                LName = lastNameEntry.Text,
                Email = emailEntry.Text,
                PhoneNum = phoneNumberEntry.Text,
            };

            await App.Database.SavePersonalAsync(InfoStuff);

            var info = await App.Database.GetInfo();

            var infoList = new ObservableCollection<PersonalInfo>();
            info.ForEach(x => infoList.Add(x));

           

            PersonalInfoListView.ItemsSource = infoList;
        }

        private async void clearButton_Clicked(object sender, EventArgs e)
        {
            await App.Database.ClearInfo();

            var info = await App.Database.ClearInfo();

            var infoList = new ObservableCollection<PersonalInfo>();
            info.ForEach(x => infoList.Add(x));
            info.Clear();

            PersonalInfoListView.ItemsSource = infoList;
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        public async void FetchInfo()
        {
            var info = await App.Database.GetInfo();

            var infoList = new ObservableCollection<PersonalInfo>();
            info.ForEach(x => infoList.Add(x));

            PersonalInfoListView.ItemsSource = infoList;
        }
    }
}
