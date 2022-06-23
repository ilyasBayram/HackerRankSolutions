using System;
using System.Collections.Generic;

namespace MinimumDistances
{
    class Program
    {

        public static int minimumDistances(List<int> a)
        {
            int count;

            List<int> distances = new List<int>();

            for (int i = 0; i < a.Count-1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        count = Math.Abs(j - i);
                        distances.Add(count);
                    }
                }
            }

            distances.Sort();

            return distances.Count != 0 ? distances[0] : -1;
       
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 7, 1, 3, 4, 1, 7 };

            int result = minimumDistances(a);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
