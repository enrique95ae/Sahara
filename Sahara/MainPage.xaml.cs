using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Sockets;
using ProtoBuf;



namespace Sahara
{
    public partial class MainPage : ContentPage
    {
        private ItemModel _itemData = new ItemModel();
        private readonly Object _lock = new object();

        public MainPage()
        {
            InitializeComponent();
            PopulateItemListView();
        }

        public static void CreateConnection()
        {
            try
            {
                TcpClient tcpConnection = new TcpClient();
                Console.WriteLine("Connecting... \n");

                tcpConnection.Connect("127.0.0.1", 27015);

                Console.WriteLine("Connected!   \n");


            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.StackTrace);
            }
        }

        /*RETRIEVE ITEM DATA FROM SERVER HERE */
        

        //private void populateMainPage(){

        //    var itemList = new ObservableCollection<ItemModel>();

        //    var getItemDataEvent = new GetItemDataEvent();

           

        //    //For loop to get: FIRST 3 ITEMS = NEARBY ITEMS
        ////    for (int count = 0; count < 3; count++)
        ////    {
        ////        getItemDataEvent.ItemId = count;

        ////        Serializer.SerializeWithLengthPrefix(_itemData.ItemStream, getItemDataEvent, PrefixStyle.Base128);

        ////        var responseData = Serializer.DeserializeWithLengthPrefix<GetItemDataEvent>(_itemData.ItemStream, PrefixStyle.Base128);

        ////        var item = new ItemModel();

        ////        item.ItemId = responseData.ItemId;
        ////        item.ItemTitle = responseData.ItemTitle;
        ////        item.ItemDescription = responseData.ItemDescription;
        ////        item.ItemPrice = responseData.ItemPrice;
        ////        item.ItemImage1 = responseData.ItemImageSRC1;
        ////        item.ItemImage2 = responseData.ItemImageSRC2;
        ////        item.ItemImage3 = responseData.ItemImageSRC3;
        ////        item.ItemImage4 = responseData.ItemImageSRC4;
        ////        item.ItemImage5 = responseData.ItemImageSRC5;
        ////        item.ItemImage6 = responseData.ItemImageSRC6;


        ////        itemList.Add(item);

        ////    }
            
        //}



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
        private void PopulateItemListView() //the product list that everything else pulls from, will be received from server
        {
            var itemList = new ObservableCollection<ItemModel>(); //filled with placeholder items


            var item1 = new ItemModel
            {
                ItemId = 1,
                ItemTitle = "Skittles",
                ItemDescription = "Wow it's candy.",
                ItemPrice = 99.99,
                ItemImage1 = "https://nuts.com/images/auto/801x534/assets/1c99a8a7052a8cb3.jpg",
                ItemImage2 = "https://c1.staticflickr.com/6/5122/5364863258_fddcb4f13d_b.jpg",
                ItemImage3 = "https://c1.staticflickr.com/6/5325/6949012298_2764231917_z.jpg",
                ItemImage4 = "https://pbs.twimg.com/profile_images/438491912102621184/dN0Y949g.jpeg",
                ItemImage5 = "https://pre00.deviantart.net/c181/th/pre/i/2017/011/2/4/yellow_skittle_for_cole2006_by_thesparkedflame-dav2mh1.png",
                ItemImage6 = "https://www.candywarehouse.com/assets/item/regular/brown-mms-candy-127627.jpg",
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

            var item4 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Not skittles!",
                ItemDescription = "m&m are much better.",
                ItemPrice = 0.99,
                ItemImage1 = "https://cdn2.bigcommerce.com/server5100/h711h5/products/222/images/2648/mm_peanuts_loose__43589.1520041155.1280.1280.jpg?c=2",
            };

            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);

            HistoryListView.ItemsSource = itemList;
        }

        void Handle_ItemClick(object sender, System.EventArgs e) //Navigates to a page with more detail
        {
            var menuItem = (Button)sender;
            var item = (ItemModel)menuItem.CommandParameter;
            Navigation.PushAsync(new ItemPage(item));
        }

    }
}
