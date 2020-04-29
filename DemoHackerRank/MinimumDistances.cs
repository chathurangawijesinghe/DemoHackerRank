using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoHackerRank
{
    class MinimumDistances
    {
        // Complete the minimumDistances function below.
        public static int minimumDistances(int[] a)
        {
            List<int> list = new List<int>();
            for (var i = 0; i < a.Length; i++)
            {
                var index = Array.LastIndexOf(a, a[i]);
                if (index > 0 && index > i)
                {
                    list.Add(index - i);
                }
            }

            if (list.Count() > 0)
            {
                return list.Min();
            }

            return -1;
        }
    }
}
