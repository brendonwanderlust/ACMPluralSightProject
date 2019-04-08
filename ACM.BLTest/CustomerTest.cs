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
            //-- Arrange. Set up the data
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            //--Act. Access the member being tested
            var actual = customer.FullName;
            var expected = "Baggins, Bilbo";

            //--Assert. Determine the result
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

        [TestMethod]
        public void ValidateValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
               LastName = "Baggins",
               Email = "fbaggins@hobbiton.me"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            Customer customer = new Customer
            {
                
                Email = "fbaggins@hobbiton.me"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

    }
}
