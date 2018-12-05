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
        public int ItemId { get; set; }

        [ProtoMember(2)]
        public string ItemTitle { get; set; }

        [ProtoMember(3)]
        public string ItemDescription { get; set; }

        [ProtoMember(4)]
        public double ItemPrice { get; set; }

        [ProtoMember(5)]
        public string ItemImageSRC1 { get; set; }

        [ProtoMember(6)]
        public string ItemImageSRC2 { get; set; }

        [ProtoMember(7)]
        public string ItemImageSRC3 { get; set; }

        [ProtoMember(8)]
        public string ItemImageSRC4 { get; set; }

        [ProtoMember(9)]
        public string ItemImageSRC5 { get; set; }

        [ProtoMember(10)]
        public string ItemImageSRC6 { get; set; }

        public GetItemDataEvent()
        {
            Type = EventType.GetItemData;
            ItemId = -1;
            ItemTitle = null;
            ItemDescription = null;
            ItemPrice = 0.0;
            ItemImageSRC1 = null;
            ItemImageSRC2 = null;
            ItemImageSRC3 = null;
            ItemImageSRC4 = null;
            ItemImageSRC5 = null;
            ItemImageSRC6 = null;

        }

        public GetItemDataEvent(int id, string title, string description, double price, string imageSRC1, string imageSRC2, string imageSRC3, string imageSRC4, string imageSRC5, string imageSRC6)
        {
            Type = EventType.GetItemData;
            ItemId = id;
            ItemTitle = title;
            ItemDescription = description;
            ItemPrice = price;
            ItemImageSRC1 = imageSRC1;
            ItemImageSRC2 = imageSRC2;
            ItemImageSRC3 = imageSRC3;
            ItemImageSRC4 = imageSRC4;
            ItemImageSRC5 = imageSRC5;
            ItemImageSRC6 = imageSRC6;
        }

    }
}