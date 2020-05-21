namespace ACM.BL.Properties
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product();

            if (productId == 2)
            {
                product.name = "Sunflowers";
                product.description = "Assort size set of 4 bright yellow mini sunflowers";
                product.currentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}