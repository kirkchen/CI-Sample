using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CI_Sample.Test
{
    [TestClass]
    public class PriceDiscountServiceTest
    {
        [TestMethod]
        public void PriceOver100Got80PercentDiscount()
        {
            // Arrange
            PriceDiscountService service = new PriceDiscountService();
            double totalPrice = 120;
            double expected = 96;
            double actual = 0;

            // Act
            actual = service.Calculate(totalPrice);

            // Assert
            Assert.AreEqual<double>(expected, actual);
        }

        [TestMethod]
        public void PriceLessThan20GotNoDiscount()
        {
            // Arrange
            PriceDiscountService service = new PriceDiscountService();
            double totalPrice = 10;
            double expected = 10;
            double actual = 0;

            // Act
            actual = service.Calculate(totalPrice);

            // Assert
            Assert.AreEqual<double>(expected, actual);
        }

        [TestMethod]
        public void PriceLessThan100AndOver20Got80PercentDiscount()
        {
            // Arrange
            PriceDiscountService service = new PriceDiscountService();
            double totalPrice = 90;
            double expected = 81;
            double actual = 0;

            // Act
            actual = service.Calculate(totalPrice);

            // Assert
            Assert.AreEqual<double>(expected, actual);
        }
    }
}
