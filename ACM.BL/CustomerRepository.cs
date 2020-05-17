namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.emailAddress = "zuyatna@gmal.com";
                customer.firstName = "Suyatna";
                customer.lastName = "Light";
            }

            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}