using System;
using System.Collections.Generic;
using System.Diagnostics;

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

        public override string ToString()
        {
            Debug.Assert(orderDate != null, nameof(orderDate) + " != null");
            return $"{orderDate.Value.Date} ({orderId})";
        }

        public bool Validate()
        {
            bool isValid = !(orderDate == null);

            return isValid;
        }
    }
}
