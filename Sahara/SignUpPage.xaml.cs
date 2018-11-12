using System;
using System.Collections.Generic;
using System.Net.Sockets;
using ProtoBuf;

using Xamarin.Forms;

namespace Sahara
{
    public partial class SignUpPage : ContentPage
    {
        private UserModel _userData = new UserModel();


        public SignUpPage()
        {
            InitializeComponent();
        }

        public SignUpPage(UserModel userData)
        {
            InitializeComponent();
            _userData = userData;
            _userData.UserEmail = "testEmail";
            _userData.UserPassword = "testPassword";
        }

        async void CreateAccountButton_Clicked(object sender, EventArgs e)
        {
            //Creating an instance of an object of type CreateAccountEvent to store the data from the Text Entries from the SignUpPage of the GUI.
            var newAccountInfo = new CreateAccountEvent(emailEntry.Text, passwordEntry.Text, RepeatPasswordEntry.Text);

            if(passwordEntry.Text == RepeatPasswordEntry.Text)
            {
                //Checking if the Application is not connected to the server. 
                if (!Globals.UserConnected)
                {
                    var tcpClient = new TcpClient("127.0.0.1", 27015);
                    _userData = new UserModel(tcpClient);
                    Globals.UserConnected = true;
                }

                //Transforms the newAccountInfo into a "Protocol Buffer Representation" ready to be sent to the server where it will be deserialized.
                Serializer.SerializeWithLengthPrefix(_userData.UserStream, newAccountInfo, PrefixStyle.Base128);

                //var responseFromServer = Serializer.DeserializeWithLengthPrefix<>

                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error:", "Passwords don't match, try again.", "OK");
            }

        }
    }
}