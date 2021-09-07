using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRanks
{
    public class GradingStudents
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> newGrades = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    int mod5 = grades[i] % 5;
                    if (mod5 > 2)
                    {
                        grades[i] += 5 - mod5;
                    }
                }
                newGrades.Add(grades[i]);
            }
            return newGrades;
        }
    }
}
