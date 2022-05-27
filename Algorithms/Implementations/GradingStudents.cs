using System;
using System.Collections.Generic;

namespace GradinStudent
{
    class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    grades[i] = grades[i];
                }
                else
                {
                    if ((grades[i] + 1) % 5 == 0)
                    {
                        grades[i] += 1;
                    }
                    else if ((grades[i] + 2) % 5 == 0)
                    {
                        grades[i] += 2;
                    }
                    else
                    {
                        grades[i] = grades[i];
                    }
                }
            
            }
            
            return grades;
        }

        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            Console.WriteLine("Please enter the students number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the grade");
                grades.Add(Convert.ToInt32(Console.ReadLine()));
            }

            gradingStudents(grades);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(grades[i]);
            }
            Console.ReadLine();
        }
    }
}
