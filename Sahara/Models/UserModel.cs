using System;

namespace Sahara
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string CreditCardNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int ZipCode { get; set; }
        public string State { get; set; }
        public bool IsVerified { get; set; }
    }
}