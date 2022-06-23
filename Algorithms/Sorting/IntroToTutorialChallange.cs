using System;
using System.Collections.Generic;

namespace IntroToTutorialChallange
{
    class Program
    {
        // you can use "indexOf()" method either.
        // return arr.indexOf(V);
        public static int introTutorial(int V, List<int> arr)
        {
            int answer = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == V)
                {
                    answer = i;
                }
            }
            return answer;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 4, 5, 7, 9, 12 };
            int V = 4;
            int result = introTutorial(V, arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
