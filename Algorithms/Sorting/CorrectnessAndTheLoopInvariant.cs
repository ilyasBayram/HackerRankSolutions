using System;
using System.Collections.Generic;

namespace CorrectnessAndTheLoopInvariant
{
    class Program
    {

        public static void insertionSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int value = A[i];
                int j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j -=1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }

        static void Main(string[] args)
        {
            int[] A = { 7, 4, 3, 5, 6, 2 };

            insertionSort(A);
            Console.ReadLine();
        }
    }
}
