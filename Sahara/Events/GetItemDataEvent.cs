using System;
using ProtoBuf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahara
{
    [ProtoContract]
    public class GetItemDataEvent : BaseEvent
    {
        [ProtoMember(1)]
        public string ItemTitle { get; set; }

        [ProtoMember(2)]
        public string ItemDescription { get; set; }

        [ProtoMember(3)]
        public double ItemPrice { get; set; }

        public GetItemDataEvent()
        {
            Type = EventType.GetItemData;
            ItemTitle = null;
            ItemDescription = null;
            ItemPrice = 0.0;
        }

        public GetItemDataEvent(string title, string description, double price)
        {
            Type = EventType.GetItemData;
            ItemTitle = title;
            ItemDescription = description;
            ItemPrice = price;
        }

    }
}