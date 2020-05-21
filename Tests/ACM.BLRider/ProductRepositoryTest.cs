using ACM.BL;
using ACM.BL.Properties;
using Xunit;

namespace ACM.BLRider
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                currentPrice = 15.96M,
                description = "Assort size set of 4 bright yellow mini sunflowers",
                name = "Sunflowers"
            };

            var actual = productRepository.Retrieve(2);
            
            Assert.Equal(expected.currentPrice, actual.currentPrice);
            Assert.Equal(expected.description, actual.description);
            Assert.Equal(expected.name, actual.name);
        }
    }
}