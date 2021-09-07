﻿using System;

using System.Collections.Generic;

namespace HackerRanks
{
    class Program
    {
        static void Main(string[] args)
        {
            kangaroo(43, 5, 49, 3);
            Console.ReadLine();
        }

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
