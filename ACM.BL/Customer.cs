using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            this.customerId = customerId;
            addressList = new List<Address>();
        }
        
        public List<Address> addressList { get; set; }
        public int customerId { get; private set; }
        public int customerType { get; set; }
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get
            {
                string name = firstName;
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        name += " ";
                    }
                    name += lastName;
                }

                return name;
            }
        }

        public override string ToString() => fullName;

        public bool Validate()
        {
            bool isValid = !string.IsNullOrWhiteSpace(firstName);

            if (string.IsNullOrWhiteSpace(emailAddress)) isValid = false;

            return isValid;
        }
    }
}
