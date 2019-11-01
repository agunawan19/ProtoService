using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoBusiness
{
    public class PriceCalculation : IPriceCalculation
    {
        private int NumberOfDecimal { get; } = 2;

        public decimal CalculateDiscount(decimal price, decimal discountPercentage) =>
            Math.Round(price * discountPercentage / 100, NumberOfDecimal);

        public decimal CalculateNetPrice(decimal price, decimal discountAmount) =>
            price - discountAmount;

        public decimal CalculateSalesTaxAmount(decimal netPrice, decimal salesTaxPercentage) =>
            Math.Round(netPrice * salesTaxPercentage / 100, NumberOfDecimal);

        public decimal CalculateTotalPrice(decimal netPrice, decimal salesTaxAmount, decimal additionalFees) =>
            netPrice + salesTaxAmount + additionalFees;
    }
}