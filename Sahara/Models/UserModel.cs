using System;
using System.Net.Sockets;


namespace Sahara
{
    public class UserModel
    {
        public TcpClient TcpClient { get; set; }
        public NetworkStream UserStream { get; set; }


        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        /*  ALL THIS NEEDS TO BE REARANGED FOR COHESION
        public string UserCreditCardNumber { get; set; }
        public string UserAddressLine1 { get; set; }
        public string UserAddressLine2 { get; set; }
        public int UserZipCode { get; set; }
        public string UserState { get; set; }
        public bool UserIsVerified { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserLastName { get; set; }
        public int UserId { get; set; }
        */

        public UserModel()
        {
            TcpClient = null;
            UserStream = null;
            UserName = null;
            UserEmail = null;
            UserPassword = null;
        }


        public UserModel(TcpClient tcpClient)
        {
            TcpClient = tcpClient;
            UserStream = TcpClient.GetStream();

            UserName = "testName";
            UserEmail = "testEmail";
            UserPassword = "testPassword";
        }
    }
}