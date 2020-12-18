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
            Console.WriteLine($"Object: {myObject} ");
            Console.WriteLine($"Product: {product} ");

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.hasChange)
            {
                if (product.isValid)
                {
                    if (product.isNew)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                        // call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }   
            
            return success;
        }
    }
}