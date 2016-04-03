using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    public class CustomTextSerializer : IAuthotSerializer
    {

        public void Serializing(Author author, string fileName)
        {
            List<string> authorInfo = new List<string>();
            authorInfo.Add(author.Name);
            authorInfo.Add(author.Email);

            foreach (var book in author.Books)
            {
                authorInfo.Add(string.Format($"{book.Title}:{book.PublishDate.ToShortDateString()}"));
            }

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var item in authorInfo)
                {
                    sw.WriteLine(item);
                }
            }
        }

        public Author Deserializing(string filePath)
        {
            string line = string.Empty;
            List<string> authorInfor = new List<string>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (true)
                {
                    line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    authorInfor.Add(line);
                }
            }

            Author author = new Author();
            author.Name = authorInfor[0];
            author.Email = authorInfor[1];

            for (int i = 2; i < authorInfor.Count; i++)
            {
                string[] bookInfor = authorInfor[i].Split(':');
                var book = new Book();
                book.Title = bookInfor[0];
                book.PublishDate = DateTime.Parse(bookInfor[1]);
                author.Books.Add(book);
            }

            return author;

        }

        
    }
}
