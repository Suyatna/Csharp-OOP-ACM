using ACM.BL;
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
                productName = "Sunflowers"
            };

            var actual = productRepository.Retrieve(2);
            
            Assert.Equal(expected.currentPrice, actual.currentPrice);
            Assert.Equal(expected.description, actual.description);
            Assert.Equal(expected.productName, actual.productName);
        }

        [Fact]
        public void SaveTestValid()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                currentPrice = 18M,
                description = "assorted size set of 4 bright yellow mini sunflower",
                productName = "sunflower",
                hasChange = true
            };
            
            // act
            var actual = productRepository.Save(updateProduct);
            
            // assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                currentPrice = null,
                description = "assorted size set of 4 bright yellow mini sunflower",
                productName = "sunflower",
                hasChange = true
            };
            
            // act
            var actual = productRepository.Save(updateProduct);
            
            // assert
            Assert.False(actual);
        }
    }
}