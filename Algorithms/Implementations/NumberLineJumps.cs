using System;

namespace NumberLineJumps
{
    class Program
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int a=x1+v1, b=x2+v2;
            for (int i = 0; a <= b; i++)
            {
                if (a == b)
                {
                    return "YES";
                }
                else
                {
                    a += v1;
                    b += v2;
                }
            }
            return "NO";
        }
        static void Main(string[] args)
        {
            
        }
    }
}
