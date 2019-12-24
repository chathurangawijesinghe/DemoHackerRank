using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DemoHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountApplesAndOranges.countApplesAndOranges(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 });
            Kangaroo.kangaroo(0, 3, 4, 2);
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
