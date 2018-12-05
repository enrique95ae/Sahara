using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sahara
{
	public partial class SearchResultsPage : ContentView
	{
		public SearchResultsPage()
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

            itemList.Add(item1);

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