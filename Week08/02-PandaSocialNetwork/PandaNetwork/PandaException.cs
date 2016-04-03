using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaNetwork
{
    public class PandaException:Exception
    {
        public PandaException()
        {

        }
        public PandaException(string message): base (message)
        {

        }

        public PandaException(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
