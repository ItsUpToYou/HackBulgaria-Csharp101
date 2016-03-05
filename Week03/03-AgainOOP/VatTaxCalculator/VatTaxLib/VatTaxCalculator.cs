using System;
using System.Collections.Generic;

namespace VatTaxLib
{
    /// <summary>
    /// Class which calculate the price with vat tax
    /// </summary>
    public class VatTaxCalculator
    {
        private List<CountryVatTax> listCountries;

        public VatTaxCalculator(List<CountryVatTax> listCountries)
        {
            this.listCountries = new List<CountryVatTax>(listCountries.Count);
            foreach (var country in listCountries)
            {
                this.listCountries.Add(country);
            }
        }

        public decimal CalculateTax(decimal productPrice, string countryId)
        {
            foreach (var country in listCountries)
            {
                if (country.CountryID == countryId)
                {
                    return productPrice + productPrice * country.VatTax;
                }
            }

            var except = new NotSupportedException("The Country ID is not found in the database");
            throw except;
        }

        public decimal CalculateTax(decimal productPrice)
        {
            foreach (var country in listCountries)
            {
                if (country.IsDefault)
                {
                    return productPrice + productPrice * country.VatTax;
                }
            }
            var except = new NotSupportedException("The default country is not found!");
            throw except;
        }

        public class NotSupportedCountryException : Exception
        {
            public NotSupportedCountryException(){}

            public NotSupportedCountryException(string message) : base(message)
            {

            }
        }
    }//end class
}//end namespace
