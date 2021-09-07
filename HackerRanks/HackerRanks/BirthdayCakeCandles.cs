using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            long max = 0;
            int maxCount = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (max < candles[i])
                {
                    max = candles[i];
                    maxCount = 0;
                }
                if (max == candles[i])
                {
                    maxCount++;
                }
            }

            return maxCount;
        }
    }
}
