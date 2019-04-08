using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            //--Act
            var actual = customer.FullName;
            var expected = "Baggins, Bilbo";

            //--Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            Customer c1 = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount += 1;

            Customer c2 = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount += 1;

            Customer c3 = new Customer
            {
                FirstName = "Rosie"
            };
            Customer.InstanceCount += 1;


           

            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
