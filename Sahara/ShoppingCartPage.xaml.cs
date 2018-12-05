using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sahara
{
    public partial class shoppingCartPage : ContentPage
    {

        public shoppingCartPage()
        {
            InitializeComponent();

            PopulateShoppingCart();
        }

        private void PopulateShoppingCart()
        {
            var ItemList = new ObservableCollection<ItemModel>();
            

                var item1 = new ItemModel
                    {
                    ItemId = 4,
                    ItemTitle = "Literally Asparagus",
                    ItemDescription = "There's festivals n stuff for this.",
                    ItemPrice = 5.99,
                    ItemImage1 = "https://hips.hearstapps.com/del.h-cdn.co/assets/18/09/2048x1024/landscape-1519653347-delish-roasted-asparagus-1.jpg?resize=1200:*",
                    };
            var item2 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Hardcore Mountain Bike",
                ItemDescription = "For grizzled veterans and manly men.",
                ItemPrice = 3999.99,
                ItemImage1 = "https://womencyclists.files.wordpress.com/2012/10/girl-bike.jpg",
            };
            var item3 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Hype Stuff",
                ItemDescription = "Get swole, bruh.",
                ItemPrice = 2.79,
                ItemImage1 = "https://cdn.shopify.com/s/files/1/0944/0726/products/VPX-Bang-Energy-Drinks_2000x.jpg?v=1543424446",
            };
            var item4 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Buttons To Press",
                ItemDescription = "We like buttons.",
                ItemPrice = 59.99,
                ItemImage1 = "https://images-na.ssl-images-amazon.com/images/I/41ecZxB3MoL._SX425_.jpg",
            };

            ItemList.Add(item1);
            ItemList.Add(item2);
            ItemList.Add(item3);
            ItemList.Add(item4);

            shoppingCartListView.ItemsSource = ItemList;

        }
        

    }
}