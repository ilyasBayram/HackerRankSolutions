using System;
using System.Collections.Generic;

namespace SequanceAquation
{
    class Program
    {

        public static List<int> permutationEquation(List<int> p)
        {
            List<int> result = new List<int>();

            int indexFirst = 0;
            int indexSecond = 0;

            for (int i = 1; i < p.Count+1; i++)
            {
                indexFirst = p.IndexOf(i);
                indexSecond = p.IndexOf(indexFirst+1);
                result.Add(indexSecond+1);
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            List<int> p = new List<int>();

            Console.Write("Please enter how manys numbers will be in the list: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nPlease enter {0}. number of the list: ", i+1);
                p.Add(int.Parse(Console.ReadLine()));
            }
            
            List<int> result = permutationEquation(p);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine("\n"+result[i]);
            }
            
            Console.ReadLine();
        }
    }
}
