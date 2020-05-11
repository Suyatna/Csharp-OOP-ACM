using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public int productId { get; private set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal? currentPrice { get; set; }

        public Product()
        {

        }

        public Product(int productId)
        {
            this.productId = productId;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(name)) isValid = false;
            if (currentPrice == null) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }
    }
}
