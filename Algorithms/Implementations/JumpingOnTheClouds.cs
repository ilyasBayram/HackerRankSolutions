using System;
using System.Collections.Generic;

namespace JumpingOnTheClouds
{
    class Program
    {

        public static int jumpingOnClouds(List<int> c)
        {
            int count = 0;

            for (int i = 0; i < c.Count-1; i++)
            {
                if (c[i + 1] == 1)
                {
                    count++;
                    i += 1;
                }
                else if (i != c.Count - 2)
                {
                    if (c[i + 1] == 0 && c[i + 2] == 0)
                    {
                        count++;
                        i += 1;
                    }
                    else if (c[i + 1] == 0 && c[i + 2] == 1)
                    {
                        count++;
                    }
                }
                else if (c[i + 1] == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            List<int> c = new List<int>();
            Console.Write("Please enter how may numbers will be : ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i < n; i++)
            {
                Console.Write("\nPlease enter the {0}. number of list:", i + 1);
                c.Add(int.Parse(Console.ReadLine()));
            }
            int result = jumpingOnClouds(c);
            Console.WriteLine("\n"+result);
            Console.ReadLine();
        }
    }
}
