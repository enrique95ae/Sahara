using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sahara
{
    public partial class profilePage : ContentPage
    {
        public profilePage()
        {
            InitializeComponent();
        }

        private async void messagesButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void postedItemsButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void modeButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void personalInfoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new personalInfoSettingsPage());
        }

        private async void securitySettingsButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void billingInfoButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void deliveryInfoButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
