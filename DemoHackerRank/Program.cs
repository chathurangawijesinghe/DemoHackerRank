using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace DemoHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountApplesAndOranges.countApplesAndOranges(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 });
            //CountingValleys.countingValleys(8, "UDDDUDUU");
            //JumpingOnTheClouds.jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 0 });
            //RepeatedString.repeatedString("abc", 1000000000000);
            //Arrays.hourglassSum(new int[][] {
            //    new int[] { 1,1,1,0,0,0 },
            //    new int[] { 0,1,0,0,0,0 },
            //    new int []{ 1,1,1,0,0,0 },
            //    new int []{ 0,0,2,4,4,0 },
            //    new int []{0,0,0,2,0,0 },
            //    new int []{ 0,0,1,2,4,0 }
            //});
            //Arrays.rotLeft(new int[] { 1,2,3,4,5}, 4);

            Arrays.arrayManipulation(10, new int[][] { 
                new int[] { 1, 5, 3 }, 
                new int[] { 4, 8, 7 },
                new int[] { 6, 9, 1 }
            });
            Console.WriteLine("Hello World!");
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            Stack<int> stack = new Stack<int>();
            Array.Sort(ar);

            int pairs = 0;

            foreach (var a in ar)
            {
                if (stack.Contains(a))
                {
                    stack.Pop();
                    pairs++;
                }
                else
                {
                    stack.Push(a);
                }
            }

            return pairs;
        }
    }
}
