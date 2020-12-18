using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.productId = productId;
        }
        
        public int productId { get; private set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal? currentPrice { get; set; }

        public override string ToString() => name;

        public override bool Validate()
        {
            bool isValid = !string.IsNullOrWhiteSpace(name);

            if (currentPrice == null) isValid = false;

            return isValid;
        }
    }
}
