using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public string ProductName { get; set; }

        public int ProductId { get; private set; }

        public string Description { get; set; }

        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            return true;
        }

        public Product Retrieve(int productId)
        {
            //code
            return new Product();
        }

        public bool Save()
        {
            return true;
        }
    }
}
