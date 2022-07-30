using System;
using System.Collections.Generic;

namespace CircularArrayRotation
{
    class Program
    {

        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            List<int> result = new List<int>();

            if ((k == 1 || a.Count < k) && a.Count != k)
            {
                for (int i = 0; i < k % a.Count; i++)
                {
                    int lastNumber = a[a.Count - 1];

                    a.RemoveAt(a.Count - 1);

                    a.Insert(0, lastNumber);
                }
            }
            else if (a.Count > k && a.Count != k)
            {
                for (int i = 0; i < a.Count%k; i++)
                {
                    int firstNumber = a[0];

                    a.RemoveAt(0);

                    a.Insert(a.Count, firstNumber);
                }
            }
            

            for (int i = 0; i < queries.Count; i++)
            {
                result.Add(a[queries[i]]);
            }

            return result;
        }



        static void Main(string[] args)
        {
            List<int> a = new List<int>(3) { 1, 2, 3, };

            int k = 2;

            List<int> querries = new List<int>(3) {0,1,2,};

            List<int> b = new List<int>() ;

            b =circularArrayRotation(a, k, querries);

            for (int i = 0; i<b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.ReadLine();
        }
    }
}
