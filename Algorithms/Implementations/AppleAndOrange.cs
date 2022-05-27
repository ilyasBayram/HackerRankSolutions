using System;
using System.Collections.Generic;

namespace AppleAndOrange
{
    class Program
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleFalling = 0;
            int orangeFalling = 0;
            for (int i = 0; i < m; i++)
            {
                if (a+apples[i]>=s || a + apples[i] <= t)
                {
                    appleFalling++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (b + apples[i] <= t || a + apples[i] >= s)
                {
                    orangeFalling++;
                }
            }
            Console.WriteLine(appleFalling);
            Console.WriteLine(orangeFalling);
        }

        static void Main(string[] args)
        {
          
        }
    }
}
