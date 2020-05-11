using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int customerId { get; private set; }
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

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.customerId = customerId;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(firstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(emailAddress)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
