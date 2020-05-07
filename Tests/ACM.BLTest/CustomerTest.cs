using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                firstName = "Suyatna",
                lastName = "Light"
            };

            string expected = "Suyatna Light";

            string actual = customer.fullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                firstName = "Suyatna"                
            };

            string expected = "Suyatna";

            string actual = customer.fullName;

            Assert.AreEqual(expected, actual);
        }
    }
}
