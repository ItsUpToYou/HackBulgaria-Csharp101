﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndAuthors
{
    public interface IAuthotSerializer
    {
        void Serializing(Author author, string fileName);
        Author Deserializing(string filePath);
    }
}
