using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sahara
{
    public partial class profilePage : ContentPage //lots of placeholder buttons that navigate to dead pages. will be updated
    {
        public profilePage()
        {
            InitializeComponent();
        }

        private async void messagesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new messagesPage());
        }

        private async void postedItemsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new postedItemsPage());
        }

        private async void modeButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new modePage());
        }

        private async void personalInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new personalInfoSettingsPage());
        }

        private async void securitySettingsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new securitySettingsPage());
        }

        private async void billingInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new billingInfoPage());
        }

        private async void deliveryInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new deliveryInfoPage());
        }

        private async void logInButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new logInPage());
        }

        private async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
