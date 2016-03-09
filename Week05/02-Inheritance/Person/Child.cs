using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{

    public class Child : Person
    {
        public Toys ChildToys { get; set; }

        public Child(Toys t)
        {
            this.ChildToys = t;
        }

        public override string ToString()
        {
            return string.Join("{0}{1}", ChildToys.ToString());
        }

        public override string Doing()
        {
            return "Play";
        }
    }
}
