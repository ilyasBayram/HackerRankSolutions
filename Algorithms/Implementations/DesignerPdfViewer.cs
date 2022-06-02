using System;
using System.Collections.Generic;

namespace DesignerPDFViewer
{
    class Program
    {
        public static int designerPdfViewer(List<int> h, string word)
        {
            int max = 0;
           
            for (int i = 0; i < word.Length; i++)
            {
                if (h[Convert.ToInt32(word[i]) - 97] > max)
                    max = h[Convert.ToInt32(word[i]) - 97];
            }

            return max*word.Length;
        }

        static void Main(string[] args)
        {
            List<int> h = new List<int>();
            Console.WriteLine("****Please enter the height of numbers****");
            
            for (int i = 0; i < 26; i++)
            {
                Console.Write("\nPlase enter the height of {0}. number: ", i+1);
                h.Add(int.Parse(Console.ReadLine()));
            }
           
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();
            
            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
            Console.ReadLine();
            //Console.WriteLine("Please enter the heights of latters: ");

            //for (int i = 0; i < 27; i++)
            //{
            //    Console.WriteLine("\nPlease enter the height of {0}. jumber:  ", i + 1);
            //    h.Add(int.Parse(Console.ReadLine()));
            //}

        }
    }
}
