using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkReceiveBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg1 = "HackBulgaria C# 101!";
            string msg2 = "C# Programming 101";

            ReceiveBuffer buffer = new ReceiveBuffer();
            buffer.MsgReceived += OnMessageRecived;
            buffer.BytesReceived(PacketGenerator.ConvertToByteArray(msg1));
            buffer.BytesReceived(PacketGenerator.ConvertToByteArray(msg2));
        }

        private static void OnMessageRecived(object sender, MsgArgs e)
        {
            Console.WriteLine(e.GetMessage);
        }
    }
}
