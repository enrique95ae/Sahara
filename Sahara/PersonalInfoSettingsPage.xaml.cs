using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sahara
{
    public partial class personalInfoSettingsPage : ContentPage
    {
        public personalInfoSettingsPage()
        {
            InitializeComponent();
        }

        private async void authButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sign In", "USER/PASSWORD box here", "OK", "Cancel");
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {

        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
