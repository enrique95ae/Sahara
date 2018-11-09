using System;
using Xamarin.Forms;

namespace Sahara
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemTitle { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public ImageSource ItemImage { get; set; }
    }
}