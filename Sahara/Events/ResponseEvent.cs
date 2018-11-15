using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Event process class for result of other events
 * Verifies success of events for client
 */

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
            //EventProcessSuccess = true;           //debug
        }
    }
}

