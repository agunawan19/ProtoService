using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoEntity
{
    public interface IPrice
    {
        decimal SubTotal { get; set; }
        decimal DiscountPercentage { get; set; }
        decimal DiscountAmount { get; set; }
        decimal SalesTaxPercentage { get; set; }
        decimal SalesTaxAmount { get; set; }
        decimal AdditionalFees { get; set; }
        decimal TotalPrice { get; set; }
    }
}