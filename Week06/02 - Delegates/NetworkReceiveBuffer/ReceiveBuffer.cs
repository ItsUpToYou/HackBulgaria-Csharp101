using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkReceiveBuffer
{
    public delegate void ReconstructedEventHandler(object sender, MsgArgs e);

    public class ReceiveBuffer
    {
        public event ReconstructedEventHandler MsgReceived;

        private string msg;

        public void BytesReceived(byte[] data)
        {
            var message = this.msg;
            this.msg = Encoding.UTF8.GetString(data);
            if (message != this.msg)
            {
                OnChanged(string.Format("[2 bytes: {0}][{0} bytes: {1}]", this.msg.Length, this.msg));
            }
        }

        private void OnChanged(string message)
        {
            if (this.MsgReceived != null)
            {
                this.MsgReceived(this, new MsgArgs(message));
            }
        }
    }
}
