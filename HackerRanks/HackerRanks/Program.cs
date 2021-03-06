using System;

using System.Collections.Generic;

namespace HackerRanks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 3, 2, 6, 1, 2 };
            int result = divisibleSumPairs(6, 3, arr);
            //Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0 )
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
