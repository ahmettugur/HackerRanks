using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class Staircase
    {
        public static void staircase(int n)
        {
            string stairs = "";
            for (int i = 0; i < n; i++)
            {
                stairs += "#";
                var k = n - i;
                var stairsText = stairs.PadLeft(k + stairs.Length - 1, ' ');
                Console.WriteLine(stairsText);
            }
        }
    }
}
