using VatTaxLib;

namespace VatTaxApp
{
    public class Product
    {
        private readonly decimal priceBeforeTax;
        private readonly decimal priceAfterTax;
        private readonly int country;
        private readonly string productName;
        private decimal productQuantity;
        private readonly int productId;

        public decimal PriceBeforeTax
        {
            get
            { return priceBeforeTax; }
        }

        public decimal PriceAfterTax
        {
            get
            { return priceAfterTax; }
        }

        public int ProductId
        {
            get
            { return productId; }
        }

        public decimal ProductQuantity
        {
            get
            { return productQuantity; }
            set
            { this.productQuantity = value; }
        }

        public Product(string productName, int productId, decimal productQuantity, int country, decimal priceBeforeTax, VatTaxCalculator calculate)
        {
            this.productName = productName;
            this.productId = productId;
            this.productQuantity = productQuantity;
            this.priceBeforeTax = priceBeforeTax;
            this.country = country;
            priceAfterTax = calculate.CalculateTax(priceBeforeTax);
        }
    }
}
