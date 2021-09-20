using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {
                int remain = (x1 - x2) % (v2 - v1);
                if (remain == 0)
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}
