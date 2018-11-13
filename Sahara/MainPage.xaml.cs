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
                ItemImage1 = "https://nuts.com/images/auto/801x534/assets/1c99a8a7052a8cb3.jpg",
            };
            var item2 = new ItemModel
            {
                ItemId = 2,
                ItemTitle = "Skittles But More",
                ItemDescription = "Wow it's more candy. Like holy crap that's a lotta skittles.",
                ItemPrice = 999.99,
                ItemImage1 = "http://images.tritondigitalcms.com/6616/sites/115/2018/01/19070509/skittles-300x168.jpg"
            };
            var item3 = new ItemModel
            {
                ItemId = 3,
                ItemTitle = "Scrolling Test. Skittles are average at best.",
                ItemDescription = "God these look disgusting.",
                ItemPrice = 0.99,
                ItemImage1 = "http://www.browniesfordays.com/wp-content/uploads/SKITTLES-BROWNIES-How-To-Make-Rainbow-Candy-Skittles-Brownies.jpg",
            };

            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);

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
