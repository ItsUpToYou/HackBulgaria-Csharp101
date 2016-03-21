using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkReceiveBuffer
{
    public class MsgArgs : EventArgs
    {
        private string msg;

        public MsgArgs(string message)
        {
            this.msg = message;
        }

        public string GetMessage
        {
            get
            {
                return this.msg;
            }
        }

    }
}
