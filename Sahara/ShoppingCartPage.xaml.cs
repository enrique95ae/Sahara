using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sahara
{
    public partial class shoppingCartPage : ContentPage
    {
        public ObservableCollection<ItemModel> ItemList { get; set; }

        public shoppingCartPage()
        {
            InitializeComponent();

            PopulateShoppingCart();
        }

        private void PopulateShoppingCart()
        {
            ItemList = new ObservableCollection<ItemModel>()
            {
                new ItemModel()
                {
                    ItemTitle = "Profile Picture",
                    ItemPrice = 200,
                    ItemImage1 = "profilePic.jpg"

				},

				new ItemModel()
				{
                    ItemTitle = "Shopping cart",
                    ItemPrice = 1000,
                    ItemImage1 = "shoppingCart.jpg"
				},

                new ItemModel()
                {
                    ItemTitle = "item 3",
                    ItemPrice = 50,
                    ItemImage1 = "profilePic.jpg"
                }

            };

            shoppingCartListView.ItemsSource = ItemList;
        }

    }
}