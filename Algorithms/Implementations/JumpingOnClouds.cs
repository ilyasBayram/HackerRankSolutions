using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c, int k)
        {
            int index = 0;
            int e = 100;

            for (int i = 0; i < c.Length / k - 1; i++)
            {
                if (c[index+k] == 0)
                {
                    e--;
                    index += k;
                }
                else if (c[index+k] == 1)
                {
                    e -= 3;
                    index += k;
                }
            }
            if (c[0] == 0)

                e--;

            else if(c[0] == 1)

                e -= 3;

            return e;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter cloud number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter jump number: ");
            int k = int.Parse(Console.ReadLine());
            int[] c = new int [n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nPlease enter the {0}. index of array: ", i+1);
                c[i] = int.Parse(Console.ReadLine());
            }
            int result = jumpingOnClouds(c, k);
            Console.WriteLine("\n"+result);
            Console.ReadLine();
        }
    }
}
