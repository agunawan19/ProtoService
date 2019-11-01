using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ProtoEntity;
using ProtoBusiness;

namespace ProtoService
{
    /// <summary>
    /// Summary description for PriceCalculation
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class PriceCalculation : System.Web.Services.WebService
    {
        [WebMethod]
        public Price CalculatePrice(decimal price, decimal discountPercentage, decimal salesTaxPercentage, decimal additonalFees)
        {
            var priceCalculation = new ProtoBusiness.PriceCalculation();
            decimal discountAmount = priceCalculation.CalculateDiscount(price, discountPercentage);
            decimal netPrice = priceCalculation.CalculateNetPrice(price, discountAmount);
            decimal salesTaxAmount = priceCalculation.CalculateSalesTaxAmount(netPrice, salesTaxPercentage);
            decimal totalPrice = priceCalculation.CalculateTotalPrice(netPrice, salesTaxAmount, additonalFees);

            return new Price()
            {
                SubTotal = price,
                DiscountPercentage = discountPercentage,
                DiscountAmount = discountAmount,
                SalesTaxPercentage = salesTaxPercentage,
                SalesTaxAmount = salesTaxAmount,
                AdditionalFees = additonalFees,
                TotalPrice = totalPrice
            };
        }
    }
}