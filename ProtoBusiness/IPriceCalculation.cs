namespace ProtoBusiness
{
    internal interface IPriceCalculation
    {
        decimal CalculateDiscount(decimal price, decimal discountPercentage);
        decimal CalculateNetPrice(decimal price, decimal discountAmount);
        decimal CalculateSalesTaxAmount(decimal netPrice, decimal salesTaxPercentage);
        decimal CalculateTotalPrice(decimal netPrice, decimal taxAmount, decimal additionalFees);
    }
}