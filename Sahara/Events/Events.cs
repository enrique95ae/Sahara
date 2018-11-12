using System;
using ProtoBuf;
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
        Response,
        GetUserData,
        GetItemData,
        UpdateUserBillingInfo
    }


    [ProtoContract]
    [ProtoInclude(50, typeof(CreateAccountEvent))]
    [ProtoInclude(51, typeof(LoginEvent))]
    [ProtoInclude(52, typeof(ResponseEvent))]


    public class BaseEvent
    {
        [ProtoMember(1)]
        public EventType Type { get; set; }
    }

    [ProtoContract]
    public class CreateAccountEvent : BaseEvent
    {
        [ProtoMember(1)]
        public string UserEmail { get; set; }

        [ProtoMember(2)]
        public string UserPassword { get; set; }

        [ProtoMember(3)]
        public string UserRepeatPassword { get; set; }


        public CreateAccountEvent()
        {
            Type = EventType.CreateAccount;
            UserEmail = null;
            UserPassword = null;
            UserRepeatPassword = null;
        }

        public CreateAccountEvent(string email, string password, string userRepeatPassword)
        {
            Type = EventType.CreateAccount;
            UserEmail = email;
            UserPassword = password;
            UserRepeatPassword = userRepeatPassword;
        }
    }

    [ProtoContract]
    public class LoginEvent : BaseEvent
    {
        [ProtoMember(1)]
        public string UserEmail { get; set; }

        [ProtoMember(2)]
        public string UserPassword { get; set; }

        public LoginEvent()
        {
            Type = EventType.Login;
            UserEmail = null;
            UserPassword = null;
        }

        public LoginEvent(string email, string password)
        {
            Type = EventType.Login;
            UserEmail = email;
            UserPassword = password;
        }
    }

    [ProtoContract]
    public class ResponseEvent : BaseEvent
    {
        [ProtoMember(1)]
        public bool EventProcessSuccess { get; set; }

        public ResponseEvent()
        {
            Type = EventType.Response;
        }

        public ResponseEvent(bool processSuccess)
        {
            Type = EventType.Response;
            EventProcessSuccess = processSuccess;
            //EventProcessSuccess = true;
        }
    }
}

