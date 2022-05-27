using System;
using System.Collections.Generic;

namespace SimpleArraySum
{
    class Program
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aPoint = 0;
            int bPoint = 0;
            
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    aPoint++;
                }
                else if (a[i] < b[i])
                {
                    bPoint++;
                }
            }
            List<int> points = new List<int> { aPoint, bPoint };
            return points;

        }
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            a.Add(Convert.ToInt32(Console.ReadLine()));
            a.Add(Convert.ToInt32(Console.ReadLine()));
            a.Add(Convert.ToInt32(Console.ReadLine()));
            b.Add(Convert.ToInt32(Console.ReadLine()));
            b.Add(Convert.ToInt32(Console.ReadLine()));
            b.Add(Convert.ToInt32(Console.ReadLine()));
            List<int> result = compareTriplets(a, b);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(result[i]);
            }


        }
    }
}
