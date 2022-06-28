using System;
using System.Collections.Generic;

namespace LonelyInteger
{
    class Program
    {

        public static int lonelyinteger(List<int> a)
        {
            int count = 0;

            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count ; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        a.RemoveAt(i);
                        a.RemoveAt(j-1);
                        i = -1;
                        break;
                    }

                }

            }

            return a[0];
        }
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 0, 0, 1, 2, 1 };

            int result = lonelyinteger(a);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
