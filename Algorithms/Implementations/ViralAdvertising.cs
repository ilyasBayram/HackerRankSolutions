using System;

namespace ViralAdvertising
{
    class Program
    {

        public static int viralAdvertising(int n)
        {
            int shared = 5;
            int cumulative = 0;

            for (int i = 0; i < n; i++)
            {
                int liked = (shared / 2);
                shared = liked * 3;
                cumulative += liked;
            }
            return cumulative;
        }

        static void Main(string[] args)
        {
            Console.Write("Please ente the The day number: ");
            int n = int.Parse(Console.ReadLine());
            int answer = viralAdvertising(n);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
