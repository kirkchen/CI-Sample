using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CI_Sample.BDD.Test.StepDefinitions
{
    [Binding]
    public class CalculateSteps
    {
        private double totalPrice;

        private double discountedPrice;

        private PriceDiscountService priceDiscountService;

        [Given(@"total price as (.*) dollar")]
        public void GivenTotalPriceAsDollar(double totalPrice)
        {
            this.totalPrice = totalPrice;

            this.priceDiscountService = new PriceDiscountService();
        }
        
        [When(@"do caculation")]
        public void WhenDoCaculation()
        {
            this.discountedPrice = this.priceDiscountService.Calculate(this.totalPrice);
        }
        
        [Then(@"discounted price is (.*) dollar")]
        public void ThenDiscountedPriceIsDollar(double discountedPrice)
        {
            Assert.AreEqual(this.discountedPrice, discountedPrice);
        }
    }
}
