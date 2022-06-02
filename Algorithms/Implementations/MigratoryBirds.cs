using System;
using System.Collections.Generic;

namespace MigratoryBirds
{
    class Program
    {
        public static int migratoryBirds(List<int> arr)
        {
            int index = 0;
            int answer = 0;
            int[] typeNumbers = new int[5];

            List<int> BirdTypeNumber1 = new List<int>();
            List<int> BirdTypeNumber2 = new List<int>();
            List<int> BirdTypeNumber3 = new List<int>();
            List<int> BirdTypeNumber4 = new List<int>();
            List<int> BirdTypeNumber5 = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[index]==1)
                {
                    BirdTypeNumber1.Add(arr[index]);
                    typeNumbers[0] = BirdTypeNumber1.Count;
                }
                else if (arr[index] == 2)
                {
                    BirdTypeNumber2.Add(arr[index]);
                    typeNumbers[1] = BirdTypeNumber2.Count;
                }
                else if (arr[index] == 3)
                {
                    BirdTypeNumber3.Add(arr[index]);
                    typeNumbers[2] = BirdTypeNumber3.Count;
                }
                else if (arr[index] == 4)
                {
                    BirdTypeNumber4.Add(arr[index]);
                    typeNumbers[3] = BirdTypeNumber4.Count;
                }
                else if (arr[index] == 5)
                {
                    BirdTypeNumber5.Add(arr[index]);
                    typeNumbers[4] = BirdTypeNumber5.Count;
                }
                index++;
            }

            int biggestNumber = typeNumbers[0];
   
            for (int i = 1; i < typeNumbers.Length; i++)
            {
                if (typeNumbers[i] > biggestNumber )
                {
                    biggestNumber= typeNumbers[i];
                    answer = i+1;
                }
                else if (typeNumbers[i] == biggestNumber)
                {
                    biggestNumber = typeNumbers[i];
                    answer = i;
                }
  
            } 

            return answer;
        }
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            int n;
            Console.WriteLine("Please enter the birds number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int result = migratoryBirds(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
