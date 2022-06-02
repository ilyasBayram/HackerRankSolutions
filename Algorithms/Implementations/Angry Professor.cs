using System;
using System.Collections.Generic;

namespace AngryProfessor
{
    class Program
    {
        public static string angryProfessor(int k, List<int> a)
        {
            int count = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] <= 0)
                    count++;
            }

            return count < k ? "YES" : "NO";

        }

        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Console.Write("Plase enter the test number: ");
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Console.Write("\nPlease enter number of students:");
                int n = int.Parse(Console.ReadLine());

                Console.Write("\nPlase enther the treshold number: ");
                int k = int.Parse(Console.ReadLine());

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("\nPlease enter {0} student arrival time: ", i + 1);
                    a.Add(int.Parse(Console.ReadLine()));
                }

                string result = angryProfessor(k, a);
                Console.WriteLine("\n" + result);
            }

            Console.ReadLine();
        }
    }
}
