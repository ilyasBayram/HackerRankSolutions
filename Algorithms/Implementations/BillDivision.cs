using System;
using System.Collections.Generic;
using System.Linq;

namespace BillDivision
{
    class Program
    {

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int totalSum = bill.Sum() / 2;
            int notEatenSum = (bill.Sum() - bill[k]) / 2;

            if (b == notEatenSum)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(totalSum - notEatenSum);
        }

        static void Main(string[] args)
        {
            List<int> bill = new List<int>() { 3, 10, 2, 9 };
            int k = 1;
            int b = 7;

            bonAppetit(bill, k, b);

            Console.ReadLine();
        }
    }
}
