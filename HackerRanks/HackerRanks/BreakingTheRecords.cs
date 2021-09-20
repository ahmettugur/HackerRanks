using System.Collections.Generic;

namespace HackerRanks
{
    public class BreakingTheRecords
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int max=scores[0],min=scores[0];
            List<int> count=new List<int>() {0,0};
            for (int i=0;i<scores.Count;i++){
                if(scores[i]>max){
                    max=scores[i];
                    count[0]++;
                }
                else if (scores[i]<min){
                    min=scores[i];
                    count[1]++;
                }
            }
            return count;
        }
    }
}