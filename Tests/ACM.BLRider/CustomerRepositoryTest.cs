using System;
using ACM.BL;
using Xunit;

namespace ACM.BLRider
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            
            var expected = new Customer(1)
            {
                emailAddress = "zuyatna@gmail.com",
                firstName = "Suyatna",
                lastName = "Light"
            };

            var actual = customerRepository.Retrieve(1);
            
            Assert.Equal(expected.customerId, actual.customerId);
            Assert.Equal(expected.emailAddress, actual.emailAddress);
            Assert.Equal(expected.firstName, actual.firstName);
            Assert.Equal(expected.lastName, actual.lastName);
        }
    }
}