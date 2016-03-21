using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    public class Configuration
    {
        public static char GetReplaceValue()
        {
            DateTime date = DateTime.Now;
            int num = ((date.Year + date.Month + date.Day + date.Hour + date.Minute + date.Second) % 25) + 65;

            return (char)num;
        }
    }
}
