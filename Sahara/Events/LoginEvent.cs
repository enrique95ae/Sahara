using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahara
{
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
}
