﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.ViewModels.Baskets
{
    public class BasketItemCreate
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
