using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public int orderId { get; private set; }
        public DateTimeOffset? orderDate { get; set; }

        public Order()
        {

        }

        public Order(int orderId)
        {
            this.orderId = orderId;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Validate()
        {
            var isValid = true;

            if (orderDate == null) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }
    }
}
