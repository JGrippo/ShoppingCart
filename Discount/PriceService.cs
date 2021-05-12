using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PriceService : IPriceService
    {
        private readonly List<Price> Prices;
        
        public PriceService()
        {
            List<Price> prices = new List<Price>();

            prices.Add(new Price( 2.0m, 'A', 1));
            prices.Add(new Price( 7.0m, 'A', 4));
            prices.Add(new Price( 12.0m, 'B', 1));
            prices.Add(new Price( 1.25m, 'C', 1));
            prices.Add(new Price( 6.0m, 'C', 6));
            prices.Add(new Price( 0.15m, 'D', 1));

            Prices = prices;
        }
        public List<Price> GetPrices()
        {
            return Prices;
        }

        public List<Price> GetPricesByProduct(char product)
        {
            return Prices.Where( price => price.ProductCode == product).ToList();
        }
    }
}
