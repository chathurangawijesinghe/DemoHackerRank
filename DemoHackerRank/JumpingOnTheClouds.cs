using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHackerRank
{
    public class JumpingOnTheClouds
    {
        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            var result = 0;

            for (var i = 0; i < c.Length; i++)
            {
                if (i+ 2 < c.Length && c[i + 2] == 0)
                {
                    result++;
                    i = i + 1;
                }
                else if (i + 1 < c.Length && c[i + 1] == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
