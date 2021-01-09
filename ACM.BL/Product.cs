using Acme.Common;

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

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        private int productId { get; set; }
        public string description { get; set; }
        public decimal? currentPrice { get; set; }

        public override bool Validate()
        {
            // ReSharper disable once LocalVariableHidesMember
            bool isValid = !string.IsNullOrWhiteSpace(productName);

            if (currentPrice == null) isValid = false;

            return isValid;
        }

        private string _productName;

        public string productName
        {
            get
            {
                var stringHandler = new StringHandler();
                
                return stringHandler.InsertSpaces(_productName);
            }

            set => _productName = value;
        }
        
        public override string ToString() => productName;
    }
}
