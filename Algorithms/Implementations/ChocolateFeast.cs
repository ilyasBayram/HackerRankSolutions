using System;

namespace ChocolateFeast
{
    class Program
    {

        public static int chocolateFeast(int n, int c, int m)
        {
            int count = n / c;
            int wrapper = n / c;

            for (int i = 0; wrapper >= m; i++)
            {
                wrapper = wrapper - (m + 1);
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            int n = 12;
            int c = 4;
            int m = 4;

            int answer = chocolateFeast(n, c, m);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
