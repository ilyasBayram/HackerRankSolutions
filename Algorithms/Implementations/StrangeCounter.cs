using System;

namespace StrangeCounter
{
    class Program
    {
        
        public static long strangeCounter(long t)
        {

            int count = 3;
            int temp = 3;
            while (temp < t)
            {
                count *= 2;
                temp += count;
            }
            return temp - t + 1;

        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the time: ");
            long t = long.Parse(Console.ReadLine());
            long result = strangeCounter(t);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
