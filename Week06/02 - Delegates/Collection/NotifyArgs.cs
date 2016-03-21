using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class NotifyArgs
    {
        private string message;

        public NotifyArgs(string msg)
        {
            this.message = msg;
        }

        public string Message
        {
            get
            {
                return this.message;
            }
        }

    }
}
