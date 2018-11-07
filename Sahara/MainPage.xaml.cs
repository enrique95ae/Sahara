using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sahara
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void shoppingCartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingCartPage());
        }

        private async void profileButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new profilePage());
        }

        private async void item1Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item2Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item3Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item4Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item5Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item6Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item7Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item8Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item9Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private async void item10Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private void previousItemButton_Clicked(object sender, EventArgs e)
        {

        }

        private void nextItemButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
