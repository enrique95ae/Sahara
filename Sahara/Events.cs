using System;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahara
{

    public static class Globals
    {
        public static bool UserConnected { get; set; }
    }


    public enum EventType
    {
        CreateAccount,
        Login,
        Logout,
        GetUserData,
        GetItemData,
        UpdateUserBillingInfo
    }


    [ProtoContract]
    [ProtoInclude(50, typeof(CreateAccountEvent))]

    public class BaseEvent
    {
        [ProtoMember(1)]
        public EventType Type { get; set; }
    }


    public class CreateAccountEvent : BaseEvent
    {
        [ProtoMember(1)]
        public string UserEmail { get; set; }

        [ProtoMember(2)]
         public string UserPassword { get; set; }


        public CreateAccountEvent()
        {
            Type = EventType.CreateAccount;
            UserEmail = null;
            UserPassword = null;
        }

        public CreateAccountEvent(string email, string password)
        {
            Type = EventType.CreateAccount;
            UserEmail = email;
            UserPassword = password;
        }

    }
}

