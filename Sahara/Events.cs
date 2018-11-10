using System;
using ProtoBuf;

namespace Sahara
{
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
//[ProtoInclude(50, typeof(CreateAccountEvent))]

    public class BaseEvent
    {
        [ProtoMember(1)]
        public EventType Type { get; set; }
    }

}

