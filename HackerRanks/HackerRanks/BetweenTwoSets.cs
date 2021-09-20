using System;
using System.Collections.Generic;

namespace HackerRanks
{
    public class BetweenTwoSets
    {
        public static int getGCD(int n1, int n2) 
        {
            if (n2 == 0) {
                return n1;
            }
            return getGCD(n2, n1 % n2);
        }

        public static int getLCM(int n1, int n2) 
        {
            if (n1 == 0 || n2 == 0)
                return 0;
            else 
            {
                int gcd = getGCD(n1, n2);
                return Math.Abs(n1 * n2) / gcd;
            }
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            var result = 0;
            // Get LCM of all elements of a
            var lcm = a[0];
            foreach(var x in a)
            {
                lcm = getLCM(lcm, x);
            }
            // Get GCD of all elements of b
            var gcd = b[0];
            foreach(var x  in b)
            {
                gcd = getGCD(gcd, x);
            }
            // Count multiples of lcm that divide the gcd
            var multiple = 0;
            while (multiple <= gcd)
            {
                multiple += lcm;
                if (gcd % multiple == 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}