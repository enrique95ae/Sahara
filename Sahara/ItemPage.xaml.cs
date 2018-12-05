using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sahara
{
    public partial class ItemPage : ContentPage
    {
        public ItemPage()
        {
            InitializeComponent();
        }

        public ItemPage(ItemModel item) //Allows use of the observable collection to fill ItemPage items
        {
            InitializeComponent();

            BindingContext = item;
        }

        private async void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("SUCCESS", "Your item has been added to the shopping cart.", "OK");
        }
    }
}
