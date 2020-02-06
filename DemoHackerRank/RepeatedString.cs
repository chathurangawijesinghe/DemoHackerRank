using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoHackerRank
{
    public class RepeatedString
    {
        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            long count = s.Count(c => c == 'a');
            long full = n / s.Count();
            int remainder = Convert.ToInt32(n % s.Count());
            string subString = s.Substring(0, remainder);

            return full * count + subString.Count(c => c == 'a');
        }
    }
}
