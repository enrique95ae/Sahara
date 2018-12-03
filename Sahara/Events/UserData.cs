using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * User Data Class for client to make server calls
 * Grabs user information
 */

namespace Sahara
{
    [ProtoContract]
    public class UserData : BaseEvent
    {
        [ProtoMember(1)]
        public string UserEmail { get; set; }

        [ProtoMember(2)]
        public string UserPassword { get; set; }

        public UserData()
        {
            Type = EventType.GetUserData;
            UserEmail = null;
            UserPassword = null;
        }

        public UserData(string name, string email, string password)
        {
            Type = EventType.GetUserData;
            UserEmail = email;
            UserPassword = password;
        }
    }
}