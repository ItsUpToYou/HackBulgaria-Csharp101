using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksAndAuthors
{
    public class AuthorSerializer : IAuthotSerializer
    {
        private XmlSerializer mySerializer;

        public AuthorSerializer()
        {
            mySerializer = new XmlSerializer(typeof(Author));
        }

        public Author Deserializing(string filePath)
        {
            using (FileStream myfile = new FileStream(filePath,FileMode.Open))
            {
               Author author = (Author) mySerializer.Deserialize(myfile);
                return author;
            }
        }

        public void Serializing(Author author, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                mySerializer.Serialize(sw, author);
            }
        }
    }
}
