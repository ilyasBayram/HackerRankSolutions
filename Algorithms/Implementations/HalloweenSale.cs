using System;

namespace AnswerToHackerRankHallowenSale
{
    class Program
    {

        public static int howManyGames(int p, int d, int m, int s)
        {
            int answer = 0;

            while (s - p >= 0)
            {
                s -= p;
                p -= d;
                if (m >= p)
                {
                    p = m;
                }
                answer++;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter initial price:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the discount price:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the last price");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the budget");
            int s = Convert.ToInt32(Console.ReadLine());

            int result = howManyGames(p, d, m, s);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
