namespace VatTaxLib
{
    public class CountryVatTax
    {
        private readonly string countryID;
        private readonly decimal vatTax;
        private readonly bool isDefault;

        public string CountryID
        {
            get
            {
                return countryID;
            }
        }

        public decimal VatTax
        {
            get
            {
                return vatTax;
            }
        }

        public bool IsDefault
        {
            get
            {
                return isDefault;
            }
        }

        public CountryVatTax(string countryId, decimal vatTax, bool isDefault )
        {
            this.countryID = countryId;
            this.vatTax = vatTax;
            this.isDefault = isDefault;
        }
    }
}
