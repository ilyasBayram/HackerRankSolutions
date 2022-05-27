using System;
using System.Collections.Generic;

namespace BreakingTheRecords
{
    class Program
    {

        public static List<int> breakingRecords(List<int> scores)
        {
            int lowScore = scores[0], highScore = scores[0];
            int lowNumber = 0, highNumber = 0;

            List<int> result = new List<int>();        
            for (int i = 0; i < scores.Count-1; i++)
            {
                if (scores[i+1] > highScore)
                { 
                    highNumber++;
                    highScore = scores[i + 1];
                }
                if (scores[i + 1] < lowScore)
                {
                    lowNumber++;
                    lowScore = scores[i + 1];

                }
            }
            result.Add(highNumber);
            result.Add(lowNumber);
            return result;

        }
        static void Main(string[] args)
        {
            int n;
            List<int> scores = new List<int>();
            List<int> answer = new List<int>();
            Console.WriteLine("Please enter the game number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the score {0}. game score", i + 1);
                scores.Add(Convert.ToInt32(Console.ReadLine()));
            }
           answer = breakingRecords(scores);
            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.ReadLine();
        }
    }
}
