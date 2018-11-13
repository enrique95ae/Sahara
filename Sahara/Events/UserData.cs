using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sahara
{
    [ProtoContract]
    public class UserData : BaseEvent
    {
        [ProtoMember(1)]
        public string UserName { get; set; }

        [ProtoMember(2)]
        public string UserEmail { get; set; }

        [ProtoMember(3)]
        public string UserPassword { get; set; }

        public UserData()
        {
            Type = EventType.GetUserData;
            UserName = null;
            UserEmail = null;
            UserPassword = null;
        }

        public UserData(string name, string email, string password)
        {
            Type = EventType.GetUserData;
            UserName = name;
            UserEmail = email;
            UserPassword = password;
        }
    }
}