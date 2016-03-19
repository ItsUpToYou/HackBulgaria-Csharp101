using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incrementable
{
    [IncrementableAttribute]
    public class TestClass
    {
        public int PropInt1 { get; set; }
        public int PropInt2 { get; set; }
        //public string PropString { get; set; }
    }
}
