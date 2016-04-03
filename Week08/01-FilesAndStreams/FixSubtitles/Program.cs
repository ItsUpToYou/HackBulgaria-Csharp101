using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixSubtitles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte[]> byteArrays = new List<byte[]>();
            string line = string.Empty;

            using (StreamReader sr = new StreamReader("lost.s04e11.hdtv.xvid-2hd.srt"))
            {
                while (true)
                {
                    line = sr.ReadLine();
                    if (line == null) break;

                    byteArrays.Add(Encoding.GetEncoding("windows-1251").GetBytes(line));
                }
            }

            using (StreamWriter sw = new StreamWriter("lost.s04e11.hdtv.xvid-2hd.html"))
            {
                foreach (var bytes in byteArrays)
                {
                    sw.WriteLine(Encoding.UTF8.GetString(bytes));
                }
            }
        }
    }
}
