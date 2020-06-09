using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        
        private AddressRepository addressRepository { get; set; }
        
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            // temporary hard-coded value to return
            // a populated customer
            if (customerId == 1)
            {
                customer.emailAddress = "zuyatna@gmail.com";
                customer.firstName = "Suyatna";
                customer.lastName = "Light";
                customer.addressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}