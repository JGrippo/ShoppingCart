using System;

namespace ShoppingCart
{
    public class Price
    {
        public decimal Cost { get; set; }
        public char ProductCode { get; set; }
        public int Quantity { get; set; }

        public Price(decimal price, char productCode, int quantity)
        {
            Cost = price;
            ProductCode = productCode;
            Quantity = quantity;
        }
    }
}