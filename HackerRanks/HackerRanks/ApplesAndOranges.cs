using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class ApplesAndOranges
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var appleCount = 0;
            var orangeCount = 0;
            int totalApplesCount = apples.Count;
            int totalOrangesCount = oranges.Count;
            int maxLength = Math.Max(totalApplesCount, totalOrangesCount);
            int distance;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < totalApplesCount)
                {
                    distance = a + apples[i];
                    if (distance >= s && distance <= t)
                    {
                        appleCount++;
                    }
                }
                if (i < totalOrangesCount)
                {
                    distance = b + oranges[i];
                    if (distance >= s && distance <= t)
                    {
                        orangeCount++;
                    }
                }
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}
