using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Sahara
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Needed for navigation.
            MainPage = new NavigationPage(new MainPage());
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

        protected override void OnStart()
        {
            CreateConnection();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
