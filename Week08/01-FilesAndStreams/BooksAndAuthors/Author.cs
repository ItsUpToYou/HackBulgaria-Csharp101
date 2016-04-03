using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    [Serializable]
    public class Author
    {
        private List<Book> books;
        public string Name { get; set; }
        public string Email { get; set; }

        public Author()
        {
            this.books = new List<Book>();
        }

        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }
    }
}
