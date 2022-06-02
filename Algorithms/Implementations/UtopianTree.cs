using System;

namespace UtopianTree
{
    class Program
    {
        public static int utopianTree(int n)
        {

            int height = 1;

            for (int i = 1; i <= n; i++)
            {
                height = i % 2 == 0? height += 1: height *= 2;
            }
            return height;

        }

        static void Main(string[] args)
        {
           
        }
    }
}
