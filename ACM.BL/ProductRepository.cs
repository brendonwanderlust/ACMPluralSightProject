﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retreive(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();
            
            return product;
        }



        public bool Save(Product product)
        {
            var success = true;

            if (product.IsValid)
            {
                if (product.IsNew)
                {
                    // Call an Insert Stored Procedure
                }
                else
                {
                    // Call an Update Stored Procedure
                }
            }
            else
            {
                success = false;
            }
            return success;
        }
    }
}
