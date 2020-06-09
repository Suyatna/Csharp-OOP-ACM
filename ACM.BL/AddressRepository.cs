using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address();
            
            // temporary hard-coded value to return
            // a populated address
            if (addressId == 1)
            {
                address.addressType = 1;
                address.streetLine1 = "Tubagus Ismail Bawah";
                address.streetLine2 = "Ir. H. Djuanda";
                address.city = "Bandung";
                address.state = "West Java";
                address.country = "Indonesia";
                address.postalCode = "1425";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // temporary hard-coded value to return
            // a set of address for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                addressType = 1,
                streetLine1 = "Tubagus Ismail Bawah",
                streetLine2 = "Ir. H. Djuanda",
                city = "Bandung",
                state = "West Java",
                country = "Indonesia",
                postalCode = "1425"
            };
            addressList.Add(address);
            
            address = new Address(2)
            {
                addressType = 2,
                streetLine1 = "Jl. Pemuda",
                city = "Bekasi",
                state = "West Java",
                country = "Indonesia",
                postalCode = "1752"
            };
            addressList.Add(address);

            return addressList;
        }
        
        public bool Save(Address address)
        {
            return true;
        }
    }
}