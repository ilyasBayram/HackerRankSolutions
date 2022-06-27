using System;
using System.Collections.Generic;

namespace CavityMap
{
    class Program
    {

        public static List<string> cavityMap(List<string> grid)
        {
            for (int i = 1; i < grid.Count - 1; i++)
            {
                for (int j = 1; j < grid.Count - 1; j++)
                {
                    if (grid[i][j] > grid[i - 1][j] && grid[i][j] > grid[i][j - 1] && grid[i][j] > grid[i][j + 1] 
                        && grid[i][j] > grid[i+1][j])
                    {
                        string temp = grid[i];
                        grid.RemoveAt(i);
                        string temp3= temp.Remove(j,1);
                        string temp2 = temp3.Insert(j,"X");
                        grid.Insert(i,temp2);

                    }
                }
            }

            return grid;
        }

        static void Main(string[] args)
        {
            List<string> grid = new List<string>() { "1112", "1912", "1892", "1234" };

            //List<string> grid = new List<string>() { "179443854", "961621369", "164139922", "968633951",
            //                                         "812882578", "257829163", "812438597", "176656233","485773814"};

            List<string> arr =cavityMap(grid);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]+"\n");
            }
            
        }
    }
}
