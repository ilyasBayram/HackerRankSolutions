using System;
using System.Collections.Generic;

namespace DivisibleSumPairs
{
    class Program
    {
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if ((ar[i] + ar[j]) % k == 0)
                        count++;

            return count;
        }
        static void Main(string[] args)
        {
            List<int> ar = new List<int>() { 1, 3, 2, 6, 1, 2 };
            int n = 6;
            int k = 3;
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
