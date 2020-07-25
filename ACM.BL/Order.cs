using System;
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

        public Order(int orderId)
        {
            this.orderId = orderId;
            orderItems = new List<OrderItem>();
        }
        
        public int customerId { get; set; }
        public int orderId { get; private set; }
        public DateTimeOffset? orderDate { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public int shippingAddressId { get; set; }

        public bool Validate()
        {
            bool isValid = !(orderDate == null);

            return isValid;
        }
    }
}
