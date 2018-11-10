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

        private async void CreateAccountButton_Clicked(object sender, EventArgs e)
        {
            var newAccountInfo = new CreateAccountEvent(emailEntry.Text, passwordEntry.Text, RepeatPasswordEntry.Text);

           
                if (!Globals.UserConnected)
                {
                    var tcpClient = new TcpClient("127.0.0.1", 27015);
                    _userData = new UserModel(tcpClient);
                    Globals.UserConnected = true;
                }
          

            Serializer.SerializeWithLengthPrefix(_userData.UserStream, newAccountInfo, PrefixStyle.Base128);

           // var responseFromServer = Serializer.DeserializeWithLengthPrefix<>


           await Navigation.PopAsync();
        }
    }
}
