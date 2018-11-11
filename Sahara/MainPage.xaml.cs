using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            PopulateItemListView();
        }

        private async void shoppingCartButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new shoppingCartPage());
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
        private void PopulateItemListView()
        {
            var itemList = new ObservableCollection<ItemModel>();

            var item1 = new ItemModel
            {
                ItemId = 1,
                ItemTitle = "Skittles",
                ItemDescription = "Wow it's candy.",
                ItemPrice = 99.99,
            };
            var item2 = new ItemModel
            {
                ItemId = 2,
                ItemTitle = "Skittles But More",
                ItemDescription = "Wow it's more candy. Like holy shit that's a lotta skittles.",
                ItemPrice = 999.99,
            };

            itemList.Add(item1);
            itemList.Add(item2);

            HistoryListView.ItemsSource = itemList;
        }

        void Handle_ItemClick(object sender, System.EventArgs e)
        {
            var menuItem = (Button)sender;
            var item = (ItemModel)menuItem.CommandParameter;
            Navigation.PushAsync(new ItemPage(item));
        }

    }
}
