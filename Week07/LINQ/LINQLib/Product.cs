namespace LINQLib
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public Product(string name, int prodId, int categId)
        {
            this.Name = name;
            this.ProductId = prodId;
            this.CategoryId = categId;
        }
    }
}
