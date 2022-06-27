using System;
using System.Collections.Generic;

namespace ManasaAndStones
{
    class Program
    {

        public static List<int> stones(int n, int a, int b)
        {
            List<int> result = new List<int>();

            for (int i = n - 1, j = 0; i >= 0; i--, j++)
            {
                int number = i * a + j * b;

                if(!result.Contains(number))
                {
                    result.Add(number);
                }

            }

            result.Sort();
            return result;

        }


        static void Main(string[] args)
        {
            List<int> answer = new List<int>();
            int n = 58;
            int a = 69;
            int b = 24;
            answer=stones(n, a, b);

            for (int i = 0; i < answer.Count; i++)
            {
                Console.Write(answer[i]+" ");
            }

            Console.ReadLine();
            
        }
    }
}
