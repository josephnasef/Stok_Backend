﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.Models
{
    public class Order
    {
        public int StockID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PersonName { get; set; }
    }
}
