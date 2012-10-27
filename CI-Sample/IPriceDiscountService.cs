using System;

namespace CI_Sample
{
    public interface IPriceDiscountService
    {
        double Calculate(double totalPrice);

        double DuplicateCalculate(double totalPrice);
    }
}