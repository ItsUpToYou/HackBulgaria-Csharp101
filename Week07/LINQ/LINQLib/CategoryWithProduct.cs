using System.Collections.Generic;

namespace LINQLib
{
    public class CategoryWithProduct
    {
        public string CategoryName { get; set; }
        public List<string> ProductNames { get; set; }
        public int CategoryId { get; set; }

        public CategoryWithProduct(string categName, List<string> prodName, int categId)
        {
            this.CategoryName = categName;
            this.ProductNames = prodName;
            this.CategoryId = categId;
        }
    }
}
