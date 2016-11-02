﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.

namespace BookShopInventoryApp.Models
{
    public class OrderModel
    {
        public int OrderNo { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int BookId { get; set; }
        public int CustomerReferenceId { get; set; }

    }
}