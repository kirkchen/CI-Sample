using System;

namespace CI_Sample
{
    /// <summary>
    /// IPriceDiscountService
    /// </summary>
    public interface IPriceDiscountService
    {
        /// <summary>
        /// Calculates the specified total price.
        /// </summary>
        /// <param name="totalPrice">The total price.</param>
        /// <returns>Result</returns>
        double Calculate(double totalPrice);

        /// <summary>
        /// Duplicates the calculate.
        /// </summary>
        /// <param name="totalPrice">The total price.</param>
        /// <returns>Result</returns>
        double DuplicateCalculate(double totalPrice);
    }
}