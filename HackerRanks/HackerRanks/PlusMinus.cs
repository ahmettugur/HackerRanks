using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class PlusMinus
    {

        public static void plusMinus(List<int> arr)
        {
            int positiveCounter = 0;
            int negativeCounter = 0;
            int zeroCounter = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                    positiveCounter++;
                else if (arr[i] < 0)
                    negativeCounter++;
                else
                    zeroCounter++;
            }

            decimal positive = Convert.ToDecimal((decimal)positiveCounter / (decimal)arr.Count);
            Console.WriteLine(String.Format("{0:0.00000}", positive));

            decimal negative = Convert.ToDecimal((decimal)negativeCounter / (decimal)arr.Count);
            Console.WriteLine(String.Format("{0:0.00000}", negative));

            decimal zero = Convert.ToDecimal((decimal)zeroCounter / (decimal)arr.Count);
            Console.WriteLine(String.Format("{0:0.00000}", zero));
        }
    }
}
