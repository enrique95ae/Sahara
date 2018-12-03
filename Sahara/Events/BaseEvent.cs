using System;
using ProtoBuf;

//Base Client event class

namespace Sahara
{
    public enum EventType
    {
        CreateAccount,
        Login,
        Logout,
        Response,
        GetUserData,
        GetItemData,
        UpdateUserBillingInfo,
        UpdateUserPaymentInfo,
    }

    [ProtoContract]
    [ProtoInclude(50, typeof(CreateAccountEvent))]
    [ProtoInclude(51, typeof(LoginEvent))]
    [ProtoInclude(52, typeof(ResponseEvent))]
    //[ProtoInclude(53, typeof(UserData))]
    [ProtoInclude(54, typeof(GetItemDataEvent))]
   //[ProtoInclude(55, typeof(BillingInfo))]
    //[ProtoInclude(56, typeof(PaymentInfo))]

    public class BaseEvent
    {
        [ProtoMember(1)]
        public EventType Type { get; set; }
    }
}