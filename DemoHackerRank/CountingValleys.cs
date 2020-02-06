using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DemoHackerRank
{
    public class CountingValleys
    {
        // Complete the countingValleys function below.
        public static int countingValleys(int n, string s)
        {
            var seaLevel = 0;
            var result = 0;
            for (var i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    seaLevel++;
                    if (seaLevel == 0)
                    {
                        result++;
                    }
                }
                else
                {
                    seaLevel--;
                }
            }

            return result;
        }
    }
}
