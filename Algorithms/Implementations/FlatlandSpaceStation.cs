using System;

namespace FlatlandSpaceStations
{
    class Program
    {

        static int flatlandSpaceStations(int n, int[] c)
        {
            Array temp = c;
            
            int count = 0;
            int temproray;

            if (c.Length == 1)
            {
                if (c[0]==0 || c[0]==n-1)
                {
                    count = n - 1;
                }
                else if (n==1)
                {
                    count = 0;
                }
                else
                {
                    count = 1;
                }
                
                return count;

            }
            else if (c.Length == n)
            {
                count = 0;
                return count;
            }
            else
            {
                for (int i = 0; i < c.Length+1; i++)
                {
                    Array.Sort(temp);

                    if (i == 0)
                    {
                        temproray = c[i] - i;
                    }
                    else if (i == c.Length)
                    {
                        temproray = (n-1) - c[i-1];
                    }

                    else if ((c[i] - c[i-1])%2==0)
                    {
                        temproray = (c[i] - c[i-1]) / 2;
                    }
                    else
                    {
                        temproray = ((c[i] - c[i-1]) -1)/ 2;
                    }

                    if(temproray > count)
                    {
                        count = temproray;
                    }

                    temproray = 0;
                }

                return count;

            }

        }

        static void Main(string[] args)
        {
            int[] c = {};
            int n = 1;

            int result = flatlandSpaceStations(n, c);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
