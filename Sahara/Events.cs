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

}

