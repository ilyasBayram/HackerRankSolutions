using System;
using System.Collections.Generic;

namespace SalesByMatches
{
    class Program
    {
        // a second soluiton with sorthing of array
        public static int SEcondsockMerchant(int n, List<int> ar)
        {
            int result = 0;
            ar.Sort();

            for (int i = 0; i < ar.Count - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    result += 1;
                    i++;
                }
            }

            return result;
        }

        //solution without sorthing of array
        public static int sockMerchant(int n, List<int> ar)
        {
            int result = 0;
            int count = 1;
            List<int> control = new List<int>();

            for (int i = 0; i < ar.Count; i++)
            {
                if (!control.Contains(ar[i]))
                {
                    for (int j = 0; j < ar.Count - 1 - i; j++)
                    {
                        if (ar[i] == ar[j + i + 1])
                        {
                            count++;
                        }
                    }
                    result += count / 2;
                    control.Add(ar[i]);
                    count = 1;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<int> ar = new List<int>();

            Console.Write("Please enter the number of socks: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the colors of socks: ");
            for (int i = 0; i < n; i++)
            {
                ar.Add(int.Parse(Console.ReadLine()));
            }

            int answer = sockMerchant(n, ar);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

    }
}
