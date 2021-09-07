using System;

using System.Collections.Generic;

namespace HackerRanks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> apples = new List<int> { -2, 2, 1 };
            List<int> oranges = new List<int> { 5, -6 };
            CountApplesAndOranges.countApplesAndOranges(7, 11, 5, 15, apples, oranges);
            Console.ReadLine();
        }
    }
}
