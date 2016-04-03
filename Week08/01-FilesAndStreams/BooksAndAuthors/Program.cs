using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuthotSerializer mySerializer = new CustomTextSerializer();
            List<Book> books = new List<Book>();
            books.Add(new Book() { Title = "Djek London", PublishDate = DateTime.Now });
            books.Add(new Book() { Title = "Linux CentOS", PublishDate = DateTime.Now });
            books.Add(new Book() { Title = "Story of Me", PublishDate = DateTime.Now });

            Author author = new Author() { Name = "Author Name", Books = books, Email = "email@email.com" };

            mySerializer.Serializing(author, "me1.txt");
            Author myTest = mySerializer.Deserializing("me1.txt");

            Console.WriteLine(myTest.Name);
            Console.WriteLine(myTest.Email);
            Console.WriteLine("Number of books {0}",myTest.Books.Count);
            foreach (var book in myTest.Books)
            {
                Console.WriteLine("{0}:{1}",book.Title, book.PublishDate.ToShortDateString());
            }
            Console.WriteLine();
        }
    }
}
