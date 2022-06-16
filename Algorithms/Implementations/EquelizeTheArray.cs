using System;
using System.Collections.Generic;

namespace equalizeTheArray
{
    class Program
    {

        public static int equalizeArray(List<int> arr)
        {
            arr.Sort();
            int count = 0;
            int temp = 1;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                    
                    temp++;

                if (i == (arr.Count - 2) || arr[i] != arr[i + 1])
                {
                    if (temp > count)

                        count = temp;

                    temp = 1;
                }
            }

            return arr.Count - count;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() {3,3,2,1,3};
            int result = equalizeArray(arr);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
