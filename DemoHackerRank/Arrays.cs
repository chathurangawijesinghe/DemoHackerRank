using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace DemoHackerRank
{
    public class Arrays
    {
        // Complete the hourglassSum function below.
        public static int hourglassSum(int[][] arr)
        {
            List<int> results = new List<int>();
            int sum = 0;
            for (var i = 0; i < arr[0].Length - 2; i++)
            {
                for (var j = 0; j < arr.Length - 2; j++)
                {
                    sum += arr[i][j];
                    sum += arr[i][j + 1];
                    sum += arr[i][j + 2];
                    sum += arr[i + 1][j + 1];
                    sum += arr[i + 2][j];
                    sum += arr[i + 2][j + 1];
                    sum += arr[i + 2][j + 2];
                    results.Add(sum);
                    sum = 0;
                }
            }

            Array.Sort(results.ToArray());
            return results.Max();
        }

        // Complete the rotLeft function below.
        public static int[] rotLeft(int[] a, int d)
        {
            var size = a.Length;
            for (var i = 1; i <= d; i++)
            {
                var temp = a[0];
                Array.Copy(a, 1, a, 0, size - 1);
                a[size - 1] = temp;
            }

            return a;
        }

        // Complete the arrayManipulation function below.
        public static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr = new long[n + 1];

            foreach (var data in queries)
            {
                arr[data[0] - 1] += data[2];
                arr[data[1]] += -data[2];
            }

            long sum = 0;
            long max = 0;
            foreach (var item in arr)
            {
                sum += item;
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max;
        }
    }
}
