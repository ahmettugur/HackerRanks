using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum1 += arr[i][(arr[i].Count - 1) - i];
                sum2 += arr[i][i];
            }
            int diagonal = Math.Abs(sum1 - sum2);

            return diagonal;
        }
    }
}
