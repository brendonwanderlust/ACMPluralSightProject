﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class Order
    {
        public Order() : this(0)
        {

        }

        public int CustomerId { get; set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public List<OrderItem> OrderItems { get; set; }

        public int OrderId { get; private set; }

        public DateTimeOffset? OrderDate { get; set; }       

        public int ShippingAddressId { get; set; }

        public bool Validate()
        {
            return true;
        }

      

    }
}
