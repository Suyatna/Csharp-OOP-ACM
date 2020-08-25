using System;

namespace ACM.BL
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

            Object myObject = new object();
            Console.WriteLine($"Object: {myObject.ToString()} ");
            Console.WriteLine($"Product: {product.ToString()} ");

            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}