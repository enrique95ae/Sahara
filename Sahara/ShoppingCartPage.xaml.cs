using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sahara
{
    public partial class shoppingCartPage : ContentPage
    {
        public ObservableCollection<Item> ItemList { get; set; }

        public shoppingCartPage()
        {
            InitializeComponent();

            PopulateShoppingCart();
        }

        private void PopulateShoppingCart()
        {
            ItemList = new ObservableCollection<Item>()
            {
                new Item()
                {
                    ItemName = "Profile Picture",
                    ItemPrice = 200,
                    ItemImage = "profilePic.jpg"

				},

				new Item()
				{
                    ItemName = "Shopping cart",
                    ItemPrice = 1000,
                    ItemImage = "shoppingCart.jpg"
				}

			};

            shoppingCartListView.ItemsSource = ItemList;
        }

    }
}