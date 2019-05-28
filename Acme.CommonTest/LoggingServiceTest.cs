using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest ()
        {
            // Arrange

            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                Email = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake With Steel Head",
                CurrentPrice = 6M
            };

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert

            
        }
    }
}
