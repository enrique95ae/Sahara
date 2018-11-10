using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sahara
{
    public partial class logInPage : ContentPage
    {
        public logInPage()
        {
            InitializeComponent();
        }

        private async void LogInButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
