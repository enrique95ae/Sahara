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
            PopulateItemNearby();
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

        private async void searchButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new searchResultsPage());
        }

        private void PopulateItemListView() //the product list that everything else pulls from, will be received from server
        {
            var itemList = new ObservableCollection<ItemModel>(); //filled with placeholder items

            var item1 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Literally Asparagus",
                ItemDescription = "There's festivals n stuff for this.",
                ItemPrice = 5.99,
                ItemImage1 = "https://hips.hearstapps.com/del.h-cdn.co/assets/18/09/2048x1024/landscape-1519653347-delish-roasted-asparagus-1.jpg?resize=1200:*",
                ItemImage2 = "https://houseofnasheats.com/wp-content/uploads/2017/03/Oven-Roasted-Asparagus-with-Garlic-Parmesan-Lemon-8-1.jpg",
                ItemImage3 = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/12/1/IG0501_31034_s4x3.jpg.rend.hgtvcom.826.620.suffix/1384540892237.jpeg",
                ItemImage4 = "https://www.thespruceeats.com/thmb/dfcgln-vBcf-OTGCjtgvQuxYjoA=/2000x1250/filters:no_upscale():max_bytes(150000):strip_icc()/Asparagus-584dcee63df78c491e8cd670.jpg",
                ItemImage5 = "https://images.media-allrecipes.com/userphotos/560x315/1001600.jpg",
                ItemImage6 = "https://www.twopeasandtheirpod.com/wp-content/uploads/2010/03/4477159251_51e896e29d.jpg",
            };
            var item2 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Hardcore Mountain Bike",
                ItemDescription = "For grizzled veterans and manly men.",
                ItemPrice = 3999.99,
                ItemImage1 = "https://womencyclists.files.wordpress.com/2012/10/girl-bike.jpg",
                ItemImage2 = "https://i5.walmartimages.com/asr/013696c9-6f7b-4bf9-85e4-1552551f77c9_1.5b9c045db8c9b56033b6000e71acc4ec.jpeg?odnHeight=450&odnWidth=450&odnBg=FFFFFF",
                ItemImage3 = "https://app.skufetch.com/images.tmp/Royalbaby_Jenny_Princess_Pink_Girl_s_Bike_with_Training_Whee_4846_0_res.jpeg",
                ItemImage4 = "http://www.ladypoolcycles.co.uk/image/cache/data/Moore%20Large/Cuda%2015/blox-14-pink-1200x1200.jpg",
                ItemImage5 = "https://image.shutterstock.com/image-vector/kids-bicycle-girl-vector-illustration-260nw-95979451.jpg",
                ItemImage6 = "https://i.ebayimg.com/images/g/~AcAAOSwq1JZJb1M/s-l300.jpg",

            };
            var item3 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Hype Stuff",
                ItemDescription = "Get swole, bruh.",
                ItemPrice = 2.79,
                ItemImage1 = "https://cdn.shopify.com/s/files/1/0944/0726/products/VPX-Bang-Energy-Drinks_2000x.jpg?v=1543424446",
                ItemImage2 = "https://images-na.ssl-images-amazon.com/images/I/91gcW2%2BRVOL._SX355_.jpg",
                ItemImage3 = "https://cdn.caffeineinformer.com/wp-content/caffeine/bang-energy-drink.jpg",
                ItemImage4 = "https://cdn.shopify.com/s/files/1/1845/0375/products/bang_pina_colada_3_1024x1024.png?v=1518000398",
                ItemImage5 = "https://cdn.shopify.com/s/files/1/2679/3646/products/rainbow_unicorn_grande_00f295fe-6d90-4be2-b938-2045afb5a184_2000x.jpg?v=1538701328",
                ItemImage6 = "https://images-na.ssl-images-amazon.com/images/I/91av8P%2BNtIL._SX522_.jpg",
            };
            var item4 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Buttons To Press",
                ItemDescription = "You are bad at MMORPGs? you can get this and get it fixed. Andrew got it and got to Diamond in LoL.",
                ItemPrice = 59.99,
                ItemImage1 = "https://images-na.ssl-images-amazon.com/images/I/41ecZxB3MoL._SX425_.jpg",
                ItemImage2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdoXeX_t3_7ENIty6s587corQ76JNkD_3pke-GBMGZvJnysOeFnA",
                ItemImage3 = "https://images.techhive.com/images/article/2014/09/razer-naga_gal-100413866-large.jpg",
                ItemImage4 = "https://cdn.nexternal.com/tecb/images/razernagammo_m.jpg",
                ItemImage5 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrCHjjVq4eFzP-ZKZLAj3OhiVt2s9IpZB5IF-DZyjYcFDmsSw",
                ItemImage6 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR7djWmU-BclsZTmpCPQ9hGm8LupBmSzD5K7fFtUJvzSv1wfxK8",
            };



            var item5 = new ItemModel
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
            var item6 = new ItemModel
            {
                ItemId = 2,
                ItemTitle = "Skittles But More",
                ItemDescription = "Wow it's more candy. Like holy crap that's a lotta skittles.",
                ItemPrice = 999.99,
                ItemImage1 = "http://images.tritondigitalcms.com/6616/sites/115/2018/01/19070509/skittles-300x168.jpg",
                ItemImage2 = "https://c1.staticflickr.com/6/5122/5364863258_fddcb4f13d_b.jpg",
                ItemImage3 = "https://c1.staticflickr.com/6/5325/6949012298_2764231917_z.jpg",
                ItemImage4 = "https://pbs.twimg.com/profile_images/438491912102621184/dN0Y949g.jpeg",
                ItemImage5 = "https://pre00.deviantart.net/c181/th/pre/i/2017/011/2/4/yellow_skittle_for_cole2006_by_thesparkedflame-dav2mh1.png",
                ItemImage6 = "https://www.candywarehouse.com/assets/item/regular/brown-mms-candy-127627.jpg",
            };
            var item7 = new ItemModel
            {
                ItemId = 3,
                ItemTitle = "Scrolling Test. Skittles are average at best.",
                ItemDescription = "God these look disgusting.",
                ItemPrice = 0.99,
                ItemImage1 = "http://www.browniesfordays.com/wp-content/uploads/SKITTLES-BROWNIES-How-To-Make-Rainbow-Candy-Skittles-Brownies.jpg",
                ItemImage2 = "https://c1.staticflickr.com/6/5122/5364863258_fddcb4f13d_b.jpg",
                ItemImage3 = "https://c1.staticflickr.com/6/5325/6949012298_2764231917_z.jpg",
                ItemImage4 = "https://pbs.twimg.com/profile_images/438491912102621184/dN0Y949g.jpeg",
                ItemImage5 = "https://pre00.deviantart.net/c181/th/pre/i/2017/011/2/4/yellow_skittle_for_cole2006_by_thesparkedflame-dav2mh1.png",
                ItemImage6 = "https://www.candywarehouse.com/assets/item/regular/brown-mms-candy-127627.jpg",
            };

            var item8 = new ItemModel
            {
                ItemId = 4,
                ItemTitle = "Not skittles!",
                ItemDescription = "m&m are much better.",
                ItemPrice = 0.99,
                ItemImage1 = "https://cdn2.bigcommerce.com/server5100/h711h5/products/222/images/2648/mm_peanuts_loose__43589.1520041155.1280.1280.jpg?c=2",
                //ItemImage1 = "https://images-na.ssl-images-amazon.com/images/I/51fxFwONaIL.jpg",
                ItemImage2 = "https://c1.staticflickr.com/6/5122/5364863258_fddcb4f13d_b.jpg",
                ItemImage3 = "https://c1.staticflickr.com/6/5325/6949012298_2764231917_z.jpg",
                ItemImage4 = "https://pbs.twimg.com/profile_images/438491912102621184/dN0Y949g.jpeg",
                ItemImage5 = "https://pre00.deviantart.net/c181/th/pre/i/2017/011/2/4/yellow_skittle_for_cole2006_by_thesparkedflame-dav2mh1.png",
                ItemImage6 = "https://www.candywarehouse.com/assets/item/regular/brown-mms-candy-127627.jpg",
            };

            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);
            itemList.Add(item5);
            itemList.Add(item6);
            itemList.Add(item7);
            itemList.Add(item8);

            HistoryListView.ItemsSource = itemList;
        }

        public void PopulateItemNearby()
        {
            var nearbyItemList = new ObservableCollection<ItemModel>();

            var nearbyItem1 = new ItemModel
            {
                ItemId = 5,
                ItemTitle = "Hardcore Mountain Bike",
                ItemDescription = "Specially designed for the hardest trails. Our team of engineers put a lot of effort into making the perfect mountain bike for all the " +
                    "contions",
                ItemPrice = 3799.99,
                ItemImage1 = "https://images-na.ssl-images-amazon.com/images/I/51fxFwONaIL.jpg",
            };

            var nearbyItem2 = new ItemModel
            {
                ItemId = 6,
                ItemTitle = "Luxury Yatch",
                ItemDescription = "For throwing legendary parties.",
                ItemPrice = 999000.00,
                ItemImage1 = "https://www.powerandmotoryacht.com/.image/c_limit%2Ccs_srgb%2Cfl_progressive%2Ch_700%2Cq_auto:good%2Cw_700/MTUwMTAyOTgzMTc5NTEwODQ2/hatteras100_prmjpg-promo-image.jpg",
            };

            var nearbyItem3 = new ItemModel
            {
                ItemId = 7,
                ItemTitle = "Reddit dope T-shirt",
                ItemDescription = "Specially designed for the hardest trails. Our team of engineers put a lot of effort into making the perfect mountain bike for all the " +
                    "contions",
                ItemPrice = 29.00,
                ItemImage1 = "https://rlv.zcache.com/reddit_alien_t_shirt-rc1ed25c8ba2f4b36a9179090d42439c1_k2gl9_307.jpg",
            };



            nearbyItemList.Add(nearbyItem1);
            nearbyItemList.Add(nearbyItem2);
            nearbyItemList.Add(nearbyItem3);

            nearbyItem1Image.Source = nearbyItem1.ItemImage1;
            nearbyItem2Image.Source = nearbyItem2.ItemImage1;
            nearbyItem3Image.Source = nearbyItem3.ItemImage1;


        }

        void Handle_ItemClick(object sender, System.EventArgs e) //Navigates to a page with more detail
        {
            var menuItem = (Button)sender;
            var item = (ItemModel)menuItem.CommandParameter;
            Navigation.PushAsync(new ItemPage(item));
        }

        void Handle_NearbyItem1Click(object sender, System.EventArgs e) //Navigates to a page with more detail
        {
            var nearbyItem1 = new ItemModel
            {
                ItemId = 5,
                ItemTitle = "Hardcore Mountain Bike",
                ItemDescription = "Specially designed for the hardest trails. Our team of engineers put a lot of effort into making the perfect mountain bike for all the " +
                 "contions",
                ItemPrice = 3799.99,
                ItemImage1 = "https://images-na.ssl-images-amazon.com/images/I/51fxFwONaIL.jpg",
                ItemImage2 = "https://i5.walmartimages.com/asr/013696c9-6f7b-4bf9-85e4-1552551f77c9_1.5b9c045db8c9b56033b6000e71acc4ec.jpeg?odnHeight=450&odnWidth=450&odnBg=FFFFFF",
                ItemImage3 = "https://app.skufetch.com/images.tmp/Royalbaby_Jenny_Princess_Pink_Girl_s_Bike_with_Training_Whee_4846_0_res.jpeg",
                ItemImage4 = "http://www.ladypoolcycles.co.uk/image/cache/data/Moore%20Large/Cuda%2015/blox-14-pink-1200x1200.jpg",
                ItemImage5 = "https://image.shutterstock.com/image-vector/kids-bicycle-girl-vector-illustration-260nw-95979451.jpg",
                ItemImage6 = "https://i.ebayimg.com/images/g/~AcAAOSwq1JZJb1M/s-l300.jpg",
            };

            var menuItem = (Button)sender;
            var item = (ItemModel)menuItem.CommandParameter;
            Navigation.PushAsync(new ItemPage(nearbyItem1));
        }

        void Handle_NearbyItem2Click(object sender, System.EventArgs e) //Navigates to a page with more detail
        {

            var nearbyItem2 = new ItemModel
            {
                ItemId = 6,
                ItemTitle = "Luxury Yatch",
                ItemDescription = "For throwing legendary parties.",
                ItemPrice = 999000.00,
                ItemImage1 = "https://www.powerandmotoryacht.com/.image/c_limit%2Ccs_srgb%2Cfl_progressive%2Ch_700%2Cq_auto:good%2Cw_700/MTUwMTAyOTgzMTc5NTEwODQ2/hatteras100_prmjpg-promo-image.jpg",
                ItemImage2 = "https://i5.walmartimages.com/asr/013696c9-6f7b-4bf9-85e4-1552551f77c9_1.5b9c045db8c9b56033b6000e71acc4ec.jpeg?odnHeight=450&odnWidth=450&odnBg=FFFFFF",
                ItemImage3 = "https://app.skufetch.com/images.tmp/Royalbaby_Jenny_Princess_Pink_Girl_s_Bike_with_Training_Whee_4846_0_res.jpeg",
                ItemImage4 = "http://www.ladypoolcycles.co.uk/image/cache/data/Moore%20Large/Cuda%2015/blox-14-pink-1200x1200.jpg",
                ItemImage5 = "https://image.shutterstock.com/image-vector/kids-bicycle-girl-vector-illustration-260nw-95979451.jpg",
                ItemImage6 = "https://i.ebayimg.com/images/g/~AcAAOSwq1JZJb1M/s-l300.jpg",
            };


            var menuItem = (Button)sender;
            var item = (ItemModel)menuItem.CommandParameter;
            Navigation.PushAsync(new ItemPage(nearbyItem2));
        }

    }
}
