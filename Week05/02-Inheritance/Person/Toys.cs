using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Toys
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Toys(string c, int s)
        {
            this.Color = c;
            this.Size = s;
        }

        public override string ToString()
        {
            return string.Join("{0},{1}", Color, Size);
        }
    }
}
