using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHackerRank
{
    public class GradingStudents
    {
        /*
 * Complete the 'gradingStudents' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts INTEGER_ARRAY grades as parameter.
 */

        public static List<int> gradingStudents(List<int> grades)
        {
            for (var i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    var mod = grades[i] % 5;
                    if (mod >= 3)
                    {
                        grades[i] += 5 - mod;
                    }
                }
            }

            return grades;
        }
    }
}
