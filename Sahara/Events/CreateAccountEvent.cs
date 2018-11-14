using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sahara
{
    [ProtoContract]
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