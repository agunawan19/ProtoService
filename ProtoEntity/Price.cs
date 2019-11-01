using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoEntity
{
    public class Price : IPrice
    {
        public decimal SubTotal { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SalesTaxPercentage { get; set; }
        public decimal SalesTaxAmount { get; set; }
        public decimal AdditionalFees { get; set; }
        public decimal TotalPrice { get; set; }
    }
}