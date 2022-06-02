using System;

namespace DrawingBook
{
    class Program
    {

        public static int pageCount(int n, int p)
        {
            
            int distanceFromPageToOne;

            int distanceFromEndToPage;

            distanceFromPageToOne = p / 2;

            distanceFromEndToPage = n / 2 - p / 2;
            
            if (distanceFromPageToOne < distanceFromEndToPage)

            return distanceFromPageToOne;

            return distanceFromEndToPage;

        }

        static void Main(string[] args)
        {
            Console.Write("Please enter how many pages the book is?: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter whic number pages you want to go to?: ");

            int p = int.Parse(Console.ReadLine());

            int result = pageCount(n, p);

            Console.WriteLine("\nThe asnwer is {0}.", result);

            Console.ReadLine();
        }
    }
}
