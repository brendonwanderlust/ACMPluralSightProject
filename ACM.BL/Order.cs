﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
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

        public override bool Validate()
        {
            var isValid = true;
            
            return isValid;
        }

        public string Log() =>
              $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";

    }
}
