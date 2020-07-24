using System;
using System.Collections.Generic;
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

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            
            var expected = new Customer(1)
            {
                emailAddress = "zuyatna@gmail.com",
                firstName = "Suyatna",
                lastName = "Light",
                addressList = new List<Address>()
                {
                    new Address()
                    {
                        addressType = 1,
                        streetLine1 = "Tubagus Ismail Bawah",
                        streetLine2 = "Ir. H. Djuanda",
                        city = "Bandung",
                        state = "West Java",
                        country = "Indonesia",
                        postalCode = "1425"
                    },
                    new Address()
                    {
                        addressType = 2,
                        streetLine1 = "Jl. Pemuda",
                        city = "Bekasi",
                        state = "West Java",
                        country = "Indonesia",
                        postalCode = "1752"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);
            
            Assert.Equal(expected.customerId, actual.customerId);
            Assert.Equal(expected.emailAddress, actual.emailAddress);
            Assert.Equal(expected.firstName, actual.firstName);
            Assert.Equal(expected.lastName, actual.lastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.addressList[i].addressType, actual.addressList[i].addressType);
                Assert.Equal(expected.addressList[i].streetLine1, actual.addressList[i].streetLine1);
                Assert.Equal(expected.addressList[i].city, actual.addressList[i].city);
                Assert.Equal(expected.addressList[i].state, actual.addressList[i].state);
                Assert.Equal(expected.addressList[i].country, actual.addressList[i].country);
                Assert.Equal(expected.addressList[i].postalCode, actual.addressList[i].postalCode);
            }
        }
    }
}