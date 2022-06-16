using System;
using System.Collections.Generic;

namespace saveThePrisoner
{
    class Program
    {
        // with that method you can find solution but gives run time error
        public static int saveThePrisonerFirst(int n, int m, int s)
        {
            List<int> prisoner = new List<int>();

            for (int i = 0; i < m; i++)
            {
                if (s == n + 1)
                {
                    s = 1;
                }
                prisoner.Add(s);
                s++;
            }

            return prisoner[m - 1];
        }

        //This method is the answer.
        public static int saveThePrisoner(int n, int m, int s)
        {
            int result = (m + (s - 1)) % n;

            return result == 0 ? n : result;
        }

        static void Main(string[] args)
        {
            int n = 7;
            int m = 19;
            int s = 2;

            int result = saveThePrisoner(n, m, s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
