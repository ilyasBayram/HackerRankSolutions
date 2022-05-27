using System;

namespace Staircase
{
    class Program
    {

        public static void Staircase(int n)
        {
            int a = n;
            int b = 1;
            for (int i = 0; i < n; i++) 
            {
                string space = new String(' ', a - 1);
                string sign = new String('#', b);
                Console.WriteLine(space+sign);
                a--;
                b++;
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            Staircase(n);
        }
    }
}
