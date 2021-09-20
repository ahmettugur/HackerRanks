using System.Collections.Generic;

namespace HackerRanks
{
    public class SubarrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for(int i=0; i <= s.Count-m ; i++)
            {
                int sum = 0;
                for(int j=i; j <i+m ; j++)
                {
                    sum = sum + s[j];
                }
                if (sum == d) {
                    count++;
                }
            }
        
        
            return count;
        }
    }
}