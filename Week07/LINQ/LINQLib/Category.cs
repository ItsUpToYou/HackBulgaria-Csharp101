namespace LINQLib
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category(int categId, string categName)
        {
            this.CategoryId = categId;
            this.CategoryName = categName;
        }
    }
}
