using System;
using System.Collections.Generic;


namespace SubarrayDivision
{
    class Program
    {

        public static int birthday(List<int> s, int d, int m)
        {
            int answer = 0;
            int index = 0;
           
            for (int i = 0; i < (s.Count-m)+1; i++)
            {
                int sum = 0;
                index = i;

                for (int j = 0; j < m; j++)
                {
                    sum += s[index];
                    
                    index++;
                }
                if (sum == d)
                {
                    answer++;
                }
            }
            return answer;

        }
        static void Main(string[] args)
        {
            int n;
            int result;
            int d;
            int m;
            List<int> s = new List<int>();
            Console.WriteLine("Please enter the bar number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the number on bars");
                s.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Please enter the birthday");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the birthday mounth");
            m = Convert.ToInt32(Console.ReadLine());
            result = birthday(s, d, m);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
