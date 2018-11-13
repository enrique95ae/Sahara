using System;
using System.Net.Sockets;


namespace Sahara
{
    public class UserModel
    {
        public TcpClient TcpClient { get; set; }
        public NetworkStream UserStream { get; set; }
        public AccountData AccountData { get; set; }

        //PERSONAL DATA
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        //public int UserId { get; set; }
        public string UserName { get; set; }
        //public string UserLastName { get; set; }
        //public string UserPhoneNumber { get; set; }

        //ADDRESS DATA
        //public string UserAddressLine1 { get; set; }
        //public string UserAddressLine2 { get; set; }
        //public string UserCity { get; set; }
        //public string UserState { get; set; }
        //public int UserZipCode { get; set; }

        //PAYMENT DATA
        //public string UserCreditCardNumber { get; set; }
        //public int UserCreditCardCVC
        //public string UserCreditCardExpirationDate { get; set; }

        //SELLING DATA
        //public bool UserIsVerified = false;

        public UserModel()
        {
            TcpClient = null;
            UserStream = null;
            UserEmail = null;
            UserPassword = null;
            UserName = null;
        }

        public UserModel(TcpClient tcpClient)
        {
            TcpClient = tcpClient;
            UserStream = TcpClient.GetStream();

            UserEmail = "testEmail";
            UserPassword = "testPassword";
            UserName = "testName";
        }
    }
}