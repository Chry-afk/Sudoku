using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [,] grid = new int[9, 9];
         
            Random rand = new Random();
            int numbersToRemove = 40; 

            for (int i = 0; i < numbersToRemove; i++)
            {
                int row = rand.Next(9);
                int col = rand.Next(9);
                grid[row, col] = rand.Next(9);
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
