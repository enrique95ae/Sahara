using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using ProtoBuf;

namespace Sahara
{
    public partial class searchResultsPage : ContentPage
    {
        public searchResultsPage()
        {
            InitializeComponent();
            PopulateSearchResultsView();
        }

        private async void item1Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        private void PopulateSearchResultsView() //the product list that everything else pulls from, will be received from server
        {
            var itemList = new ObservableCollection<ItemModel>(); //filled with placeholder items

            var item1 = new ItemModel
            {
                ItemId = 11,
                ItemTitle = "Snickers",
                ItemDescription = "Brown bars.",
                ItemPrice = 0.99,
                ItemImage1 = "https://www.sweets-online.com/images/produkte/i12/12080-12080-1_1.jpg",
                ItemImage2 = "https://images-na.ssl-images-amazon.com/images/I/51bnA3AS%2BML.jpg",
                ItemImage3 = "http://cdn.shopify.com/s/files/1/0004/8132/9204/products/snickers-almond-box2_1024x1024.jpg?v=1532192681",
                ItemImage4 = "https://thumbor.thedailymeal.com/Er8yBLt8qW5toMFIiTJMkx_KN-k=/840x565/filters:focal(595x384:596x385)/https://www.thedailymeal.com/sites/default/files/2017/12/06/copy/01-snicker.jpg",
                ItemImage5 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSsKCCYpzXieCsuCunEUdzF_iQqRoa3E_Gg6ve3dLWnb3A2OzMYQ",
                ItemImage6 = "https://images-na.ssl-images-amazon.com/images/I/71BobAGDWuL._SL1500_.jpg",
            };

            var item2 = new ItemModel
            {
                ItemId = 12,
                ItemTitle = "Smug",
                ItemDescription = "You know it...",
                ItemPrice = 0.00,
                ItemImage1 = "https://i.imgur.com/DdgoMGe.png"
            };

            var item3 = new ItemModel
            {
                ItemId = 13,
                ItemTitle = "A Doctor",
                ItemDescription = "A real doctor.",
                ItemPrice = 1000.00,
                ItemImage1 = "https://www.resolvingdiscoverydisputes.com/wp-content/uploads/sites/95/2015/01/Doctor.jpg"
            };

            var item4 = new ItemModel
            {
                ItemId = 14,
                ItemTitle = "Twinkies",
                ItemDescription = "Yellow bars.",
                ItemPrice = 2.99,
                ItemImage1 = "https://upload.wikimedia.org/wikipedia/commons/0/06/Hostess_twinkies_tweaked.jpg"
            };

            itemList.Add(item1);
           // itemList.Add(item2);
           // itemList.Add(item3);
           // itemList.Add(item4);

            SearchListView.ItemsSource = itemList;
        }

        void Handle_ItemClick(object sender, System.EventArgs e) //Navigates to a page with more detail
        {
            var menuItem = (Button)sender;
            var item = (ItemModel)menuItem.CommandParameter;
            Navigation.PushAsync(new ItemPage(item));
        }
    }
}
