using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHackerRank
{
    public class Kangaroo
    {
        // Complete the kangaroo function below.
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 == x2 && v1 == v2)
            {
                return "YES";
            }
            if ((x1 > x2 && v1 > v2) || (x2 > x1 && v2 > v1))
            {
                return "NO";
            }

            if (x1 > x2)
            {
                return CanMeet(x1, v1, x2, v2);
            }
            else
            {
                return CanMeet(x2, v2, x1, v1);
            }
        }

        static string CanMeet(int high, int d1, int low, int d2)
        {
            while (high != low)
            {
                high += d1;
                low += d2;

                if (high < low)
                {
                    break;
                }
            }

            if (high == low)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
