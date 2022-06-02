using System;


namespace CatsAndAMouse
{
    class Program
    {
        // solution with if else structure
        static string secondSolution(int x, int y, int z)
        {
            if (Math.Abs(z - y) < Math.Abs(z - x))

                return "Cat A";

            else if (Math.Abs(z - y) == Math.Abs(z - x))

                return "Mouse C";

            else

                return "Cat B";
        }

        // solution with ternary opertator
        static string CatsAndAMouse(int x, int y, int z)
        {
            return Math.Abs(z - y) < Math.Abs(z - x) ? "Cat A" : Math.Abs(z - y) == Math.Abs(z - x) ? "Mouse C"
                 : "Cat B";
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter number of queries: ");
            int q = int.Parse(Console.ReadLine());

            for (int i= 0; i < q; i++)
            {
                Console.Write("\nPlease enter the position of Cat A: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("\nPlease enter the position of Cat B: ");
                int y = int.Parse(Console.ReadLine());

                Console.Write("\nPlease enter the position of Mouse C: ");
                int z = int.Parse(Console.ReadLine());

                string result = CatsAndAMouse(x, y, z);

                Console.WriteLine("\n" + result);
            }

        }
    }
}
