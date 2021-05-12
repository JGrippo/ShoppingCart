using System.Collections.Generic;

namespace ShoppingCart {
    public interface IPriceService
    {
        public List<Price> GetPrices();
        public List<Price> GetPricesByProduct(char product);
    }
}