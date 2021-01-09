namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.productId = productId;
        }

        private int productId { get; set; }
        public string description { get; set; }
        public decimal? currentPrice { get; set; }

        public override string ToString() => productName;

        public override bool Validate()
        {
            // ReSharper disable once LocalVariableHidesMember
            bool isValid = !string.IsNullOrWhiteSpace(productName);

            if (currentPrice == null) isValid = false;

            return isValid;
        }

        public string productName { get; set; }
    }
}
