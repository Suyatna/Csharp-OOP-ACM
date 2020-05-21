using System;
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
            this.orderId = orderId;
        }
        
        public int orderId { get; private set; }
        public DateTimeOffset? orderDate { get; set; }

        public bool Validate()
        {
            bool isValid = !(orderDate == null);

            return isValid;
        }
    }
}
