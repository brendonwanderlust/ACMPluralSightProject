using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void TestTemplate()
        {
            // Arrrange

            // Act

            // Assert
        }

        [TestMethod]
        public void RetreiveTest()
        {

            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = 15.96M,
            };

            var actual = productRepository.Retreive(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductName = "Sunflowers",
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
