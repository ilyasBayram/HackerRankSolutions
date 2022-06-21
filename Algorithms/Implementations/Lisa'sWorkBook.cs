using System;
using System.Collections.Generic;

namespace lisa_sWorkBook
{
    class Program
    {
        public static int workbook(int n, int k, List<int> arr)
        {
            int page = 1;
            int count = 0;
            int pageTurn = 0;

            for (int i = 0; i < arr.Count; i++)
            {

                for (int j = 1; j < arr[i]+1; j++)
                {
                    pageTurn++;

                    if (page == j)
                    {
                        count++;
                    }
                   
                    if (j == arr[i] ||  pageTurn== k )
                    {
                        page++;
                        pageTurn = 0;
                    }

                }

                pageTurn = 0;
            }
            return count;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() {4,2,6,1,10 };
            int k = 3;
            int n = 15;

            int result = workbook(n, k, arr);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
