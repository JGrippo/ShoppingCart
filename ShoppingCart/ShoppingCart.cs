using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceService = new ShoppingCart.PriceService();
            var pointofSale = new PointofSale(priceService);

            pointofSale.Scan("ABCD");

            Console.WriteLine($"Total is {pointofSale.Total()}");
        }
    }
}
