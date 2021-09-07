using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            DateTime d = DateTime.Parse(s);
            return d.ToString("HH:mm:ss");
        }
    }
}
