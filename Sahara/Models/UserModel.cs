using System;

namespace Sahara
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserCreditCardNumber { get; set; }
        public string UserAddressLine1 { get; set; }
        public string UserAddressLine2 { get; set; }
        public int UserZipCode { get; set; }
        public string UserState { get; set; }
        public bool UserIsVerified { get; set; }
    }
}