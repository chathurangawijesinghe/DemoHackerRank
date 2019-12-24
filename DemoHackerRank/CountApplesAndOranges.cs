using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DemoHackerRank
{
    public class CountApplesAndOranges
    {
        // Complete the countApplesAndOranges function below.
        public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var applesInTheHouse = 0;
            var organgesInTheHouse = 0;

            foreach (var apple in apples)
            {
                if (apple + a >= s && apple + a <= t)
                {
                    applesInTheHouse++;
                }
            }

            foreach (var orange in oranges)
            {
                if (b + orange <= t && b+ orange >= s)
                {
                    organgesInTheHouse++;
                }
            }

            Console.WriteLine(applesInTheHouse);
            Console.WriteLine(organgesInTheHouse);
        }
    }
}
