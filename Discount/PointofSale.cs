using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PointofSale : ITerminal
    {
        private readonly IPriceService _priceService;
        private Dictionary<char, int> Cart {get;set;}
        
        public PointofSale( IPriceService priceService)
        {
            _priceService = priceService;
        }

        public decimal Total()
        {
            if (Cart.Count == 0)
            {
                Console.WriteLine("Please put some items in the cart.");
                return -1.0m;
            }

            decimal total = 0m; 

            foreach( var item in Cart)
            {
                List<Price> pricesForProduct = _priceService.GetPricesByProduct(item.Key).OrderByDescending(p => p.Quantity).ToList();
                int amountRemainingInCart = item.Value; 

                foreach( Price p in pricesForProduct)
                {
                    int factor = amountRemainingInCart / p.Quantity ; 
                    total += factor * p.Cost; 
                    amountRemainingInCart -= factor * p.Quantity; 

                }
            }

            return total;
        }

        public void Scan(string input)
        {
            Dictionary<char, int> cart = new Dictionary<char, int>();
            char[] items = input.ToCharArray();
            List<Price> prices = _priceService.GetPrices();

            foreach( char item in items)
            {
                // int index = prices.FindIndex(0, prices.Count -1, price => price.ProductCode == item); 
                var index = prices.Where(price => price.ProductCode == item); 

                if (index.Count() == 0 )
                {
                    Console.WriteLine($"The product {item} doesn't have a price. It's free!!");
                    continue;
                }
                
                cart.TryGetValue(item, out var currCount);
                cart[item] = currCount + 1;
            }

            Cart = cart;

        }
    }
}