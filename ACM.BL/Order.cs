﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        
        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }       

        public bool Validate()
        {
            return true;
        }

        public Order Retreive()
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

    }
}