using System;
using ProtoBuf;

namespace CreateAccountEvent{

    public class CreateAccountEvent : BaseEvent
    {
        [ProtoMember(1)]
        public string UserEmail { get; set; }

        [ProtoMember(2)]
        public string UserPassword { get; set; }
    }

    public CreateAccountEvent()
    {
        Type = EventType.CreateAccount;
        UserEmail = null;
        UserPasword = null;
    }

    public CreateAccountEvent(string email, string password)
    {
        Type = EventType.CreateAccount;
        UserEmail = email;
        UserPasword = password;
    }

}
