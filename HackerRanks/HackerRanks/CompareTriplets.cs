using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class CompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            List<int> answer = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    alice++;
                if (a[i] < b[i]) 
                    bob++;
            }

            answer.Add(alice);
            answer.Add(bob);
            return answer;
        }
    }
}
