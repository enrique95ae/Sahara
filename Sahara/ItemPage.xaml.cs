﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sahara
{
    public partial class ItemPage : ContentPage
    {
        public ItemPage()
        {
            InitializeComponent();
        }

        public ItemPage(ItemModel item)
        {
            InitializeComponent();

            BindingContext = item;
        }
    }
}
