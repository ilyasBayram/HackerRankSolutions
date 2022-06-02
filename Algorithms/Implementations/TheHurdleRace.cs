using System;
using System.Collections.Generic;
using System.Linq;

namespace TheHurdleRace
{
    class Program
    {
        public static int hurdleRace(int k, List<int> height)
        {
            return k > height.Max() ? 0 : height.Max()-k;
        }

        static void Main(string[] args)
        {
            List<int> height = new List<int>();

            Console.Write("\nPlease enter the hurdles number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("\nPlse enther the jump height: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nPlease enter the height of {0}. hurdle : ", i+1);
                height.Add(int.Parse(Console.ReadLine()));
            }

            int result= hurdleRace(k, height);
            Console.WriteLine("\n"+result);
            Console.ReadLine();
        }
    }
}
