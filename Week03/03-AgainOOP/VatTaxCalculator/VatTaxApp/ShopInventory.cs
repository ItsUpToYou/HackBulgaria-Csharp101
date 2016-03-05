using System;
using System.Collections.Generic;

namespace VatTaxApp
{
    public class ShopInventory
    {
        private List<Product> products;

        public ShopInventory(List<Product> prod)
        {
            this.products = new List<Product>(prod.Count);
            foreach (var product in prod)
            {
                this.products.Add(product);
            }
        }

        public decimal Audit()
        {
            decimal total = 0;

            foreach (var product in products)
            {
                total += product.PriceAfterTax * product.ProductQuantity;
            }
            return total;
        }

        public decimal RequestOrder(Order order)
        {
            foreach (KeyValuePair<int,int> itemId in order.OrderedProduct)
            {
                bool found = false;
                foreach (var product in products)
                {
                    if (product.ProductId == itemId.Key)
                    {
                        if (product.ProductQuantity >= itemId.Value)
                        {
                            found = true;
                        }
                    }
                }
                if (!found)
                {
                    throw new NotAvailableInInventoryException("Item unavailable");
                }
            }

            decimal price = 0;

            foreach (var orderItem in order.OrderedProduct)
            {
                foreach (var product in products)
                {
                    if (product.ProductId == orderItem.Key)
                    {
                        product.ProductQuantity = product.ProductQuantity - orderItem.Value;
                        price += orderItem.Value * product.PriceAfterTax;
                    }
                }
            }
            return price;
        }

        public class NotAvailableInInventoryException : Exception
        {
            public NotAvailableInInventoryException()
            {

            }

            public NotAvailableInInventoryException(string message)
                : base(message)
            {

            }
        }
    }
}
