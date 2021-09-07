using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            long min = long.MaxValue, max = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                long sum = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (j == i)
                        continue;
                    sum += arr[j];
                }

                if (sum < min) 
                    min = sum;
                if (sum > max) 
                    max = sum;
            }

            Console.WriteLine(min + " " + max);
        }
    }
}
