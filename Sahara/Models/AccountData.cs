using System;
using ProtoBuf;

/* Should this be in the Events folder?
 * Account Data Class for client event to make server calls
 * Grabs account validation information (email/password)
 */

namespace Sahara
{
    [ProtoContract]
    public class AccountData : BaseEvent
    {
        [ProtoMember(1)]
        public string UserEmail { get; set; }

        [ProtoMember(2)]
        public string UserPassword { get; set; }

        public AccountData()
        {
            Type = EventType.GetUserData;
            UserEmail = null;
            UserPassword = null;
        }

        public AccountData(string userEmail, string userPassword)
        {
            Type = EventType.GetUserData;
            UserEmail = userEmail;
            UserPassword = userPassword;

        }
    }
}