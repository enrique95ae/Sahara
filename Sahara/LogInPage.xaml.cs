using System;
using System.Collections.Generic;
using ProtoBuf;
using System.Net.Sockets;

using Xamarin.Forms;

namespace Sahara
{
    public partial class logInPage : ContentPage
    {
        private UserModel _userData = new UserModel();
        private readonly Object _lock = new object();

        //private bool DEBUG_MODE = true;

        public logInPage()
        {
            InitializeComponent();
        }

        public logInPage(UserModel userData)
        {
            InitializeComponent();

            this._userData = userData;
        }

        private async void LogInButton_Clicked(object sender, EventArgs e)
        {
            if (!Globals.UserConnected)
            {
                var tcpClient = new TcpClient("127.0.0.1", 27015); //server location
                _userData = new UserModel(tcpClient); //creates model for server use
                Globals.UserConnected = true;
            }
                var loginEvent = new LoginEvent(emailEntry.Text, passwordEntry.Text);


            //lock(_lock)
            //{
            //    Serializer.SerializeWithLengthPrefix(_userData.UserStream, loginEvent, PrefixStyle.Base128);
            //}
              
                Serializer.SerializeWithLengthPrefix(_userData.UserStream, loginEvent, PrefixStyle.Base128); //allows for communication of data


                var responseData = Serializer.DeserializeWithLengthPrefix<ResponseEvent>(_userData.UserStream, PrefixStyle.Base128);
                
                if (responseData.EventProcessSuccess)
                {
                    //If login successfully:
                    //We use the email in order to find the user in the database and retrieve it's information.
                    //_userData.AccountData.UserEmail = emailEntry.Text;


                   //Serializer.SerializeWithLengthPrefix(_userData.UserStream, _userData.AccountData, PrefixStyle.Base128);
                   //_userData.AccountData = Serializer.DeserializeWithLengthPrefix<AccountData>(_userData.UserStream, PrefixStyle.Base128);


                    await DisplayAlert("SUCCESS", "You are now logged in.", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "The Email or Passwords entered don't match our records. Try Again.", "OK");
                }   
                
        }
    }
}
