using System;
using Xunit;

namespace ShoppingCart.Test
{
    public class TotalShould
    {
        private PriceService priceService = new ShoppingCart.PriceService();
        [Fact]
        public void ABCDABAA()
        {
            var pointofSale = new PointofSale(priceService);

            pointofSale.Scan("ABCDABAA");

            Assert.Equal<decimal>(32.40m, pointofSale.Total());
        }
        [Fact]
        public void CCCCCCC()
        {
            var pointofSale = new PointofSale(priceService);

            pointofSale.Scan("CCCCCCC");

            Assert.Equal<decimal>(7.25m, pointofSale.Total());
        }
        [Fact]
        public void ABCD()
        {
            var pointofSale = new PointofSale(priceService);

            pointofSale.Scan("ABCD");

            Assert.Equal<decimal>(15.40m, pointofSale.Total());
        }
                [Fact]
        public void ABCDG()
        {
            var pointofSale = new PointofSale(priceService);

            pointofSale.Scan("ABCDG");

            Assert.Equal<decimal>(15.40m, pointofSale.Total());
        }
    }
}
