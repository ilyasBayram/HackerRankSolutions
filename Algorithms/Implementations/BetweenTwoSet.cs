using System;
using System.Collections.Generic;

namespace BetweenToSet
{
    class Program
    {

        public static int getTotalX(List<int> a, List<int> b)
        {
            List<int> temp = new List<int>();

            for (int i = 1; a[a.Count - 1] * i <= b[0]; i++)
            {
                temp.Add(a[a.Count-1]*i);
                
            }

            for (int i = 0; i < a.Count-1; i++)
            {
                for (int j= 0; j < temp.Count; j++)
                {
                    if (temp[j] % a[i] != 0)
                        temp.RemoveAt(i);
                }
                
            }

            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < b.Count; j++)
                {
                    if (b[j] % temp[i] != 0)
                    {
                        temp.RemoveAt(i);
                        i -= 2;
                        break;
                    }
                       
                }
                
            }

            return temp.Count;
        }

        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 2};
            List<int> b = new List<int>() { 20, 30, 12};

            int result = getTotalX(a, b);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
