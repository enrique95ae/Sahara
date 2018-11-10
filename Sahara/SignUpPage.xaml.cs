using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sahara
{
    public partial class SignUpPage : ContentPage
    {
        private UserModel _userData = new UserModel();

        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void CreateAccountButton_Clicked(object sender, EventArgs e)
        {
            var newAccountInfo = new CreateAccountEvent(emailEntry.Text, passwordEntry.Text);

            await Navigation.PopAsync();
        }
    }
}
