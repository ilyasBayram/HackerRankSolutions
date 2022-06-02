using System;

namespace BeastifulDaysAtTheMovies
{
    class Program
    {

        public static int beautifulDays(int i, int j, int k)
        {
            int reverseNumber = 0;
            int lastDigit;
            int count = 0;
            int constant = i;

            for (int a = 0; a < j-constant+1; a++)
            {
                int firstNumber = i;
                while (i > 0)
                {
                    lastDigit = i % 10;
                    reverseNumber = reverseNumber * 10 + lastDigit;
                    i /= 10;
                }
                if (Math.Abs((firstNumber - reverseNumber) % k) == 0)
                    count++;
                i = firstNumber+1;
                reverseNumber = 0;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of first day: ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of first day: ");
            int j = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of divisor: ");
            int k = int.Parse(Console.ReadLine());

            int result= beautifulDays(i, j, k);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
