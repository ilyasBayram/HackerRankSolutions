using System;
using System.Collections.Generic;

namespace FindDigit
{
    class Program
    {
        public static int findDigits(int n)
        {
            List<int> p = new List<int>();
            int count = 0;
            int division = 1;
            int temp = n;

            while (n > 0)
            {
                division = n % 10;
                n = n / 10;
                p.Add(division);
            }
      
            for (int i=0; i < p.Count; i++)
            {
                if (p[i]!=0 && temp % p[i] == 0)
                {
                    count += 1;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int result =findDigits(n);
            Console.WriteLine("\n"+result);
            Console.ReadLine();
        }
    }
}
