using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahara
{
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

