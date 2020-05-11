using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public int orderItemId { get; private set; }
        public int productId { get; set; }
        public decimal? purchasePrice { get; set; }
        public int quantity { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.orderItemId = orderItemId;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Validate()
        {
            var isValid = true;

            if (quantity <= 0) isValid = false;
            if (productId <= 0) isValid = false;
            if (purchasePrice == null) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }
    }
}
