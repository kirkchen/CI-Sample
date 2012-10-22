using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CI_Sample
{
    public class PriceDiscountService
    {
        private System.Threading.ManualResetEvent locker = new System.Threading.ManualResetEvent(false);

        public double Calculate(double totalPrice)
        {
            if (totalPrice > 100)
            {
                return totalPrice * 0.8d;
            }
            else if (totalPrice < 20)
            {
                return totalPrice;
            }

            return totalPrice * 0.9d;
        }

        public double DiscountCalculate(double totalPrice)
        {
            if (totalPrice > 100)
            {
                return totalPrice * 0.8d;
            }
            else if (totalPrice < 20)
            {
                return totalPrice;
            }

            return totalPrice * 0.9d;
        }
    }
}