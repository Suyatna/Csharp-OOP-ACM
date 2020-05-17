namespace ACM.BL
{
    public class Address
    {
        public Address()
        {
            
        }
        
        public Address(int addressId)
        {
            this.addressId = addressId;
        }

        public int addressId { get; private set; }
        public int addressType { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string streetLine1 { get; set; }
        public string streetLine2 { get; set; }

        public bool Validate()
        {
            bool isValid = postalCode != null;

            return isValid;
        }
    }
}