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
                ItemImage1 = "https://www.sweets-online.com/images/produkte/i12/12080-12080-1_1.jpg"
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
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);

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
