using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{


    class Program
    {
        static void Main(string[] args)
        {
            Sudoku sudoku = new Sudoku();

            Console.WriteLine(sudoku.ToString());
            sudoku.PrintGrid();
            Console.ReadKey();
        }
        
    }

    class Sudoku
    {
        public int[,] matrix =
    {
        { 0, 1, 0, 0, 0, 4, 3, 7, 0 },
        { 4, 0, 0, 0, 5, 0, 2, 0, 0 },
        { 0, 0, 8, 0, 0, 9, 5, 0, 1 },
        { 0, 0, 0, 9, 7, 0, 0, 8, 0 },
        { 0, 0, 6, 0, 8, 0, 4, 0, 0 },
        { 2, 0, 7, 0, 0, 0, 0, 1, 0 },
        { 0, 0, 0, 3, 6, 0, 0, 0, 0 },
        { 1, 3, 0, 0, 0, 2, 0, 0, 5 },
        { 0, 6, 0, 0, 0, 5, 0, 0, 9 }
    };

        // metodo che controlla se la matrice è corretta o errata
        public bool checkMatrix()
        {
            for (int number = 1; number < 10; number++) {
                for (int i = 0; i < 9; i++)
                {
                    int[] rigaArray = new int[9];
                    for (int j = 0; j < 9; j++)
                    {
                        rigaArray[j] = matrix[i, j];
                    }
                    if (rigaArray.Contains(number)) return false;
                }

                for (int i = 0; i < 9; i++)
                {
                    int[] colonnaArray = new int[9];
                    for (int j = 0; j < 9; j++)
                    {
                        colonnaArray[j] = matrix[j, i];
                    }
                    if (colonnaArray.Contains(number)) return false;
                }
            }
            return true;
        }

        public bool insert(int number, int x, int y)
        {
            if (x<10 && x>0 && y < 10 && y > 0)
            {
                matrix[x, y] = number;
            }
            return false;
        }
        public void PrintGrid()
        {
            Console.WriteLine("┌───────┬───────┬───────┐");
            foreach (var i in Enumerable.Range(0, 9))
            {
                if (i > 0 && i % 3 == 0)
                    Console.WriteLine("├───────┼───────┼───────┤");

                Console.Write("│ ");
                foreach (var j in Enumerable.Range(0, 9))
                {
                    Console.Write(matrix[i, j] == 0 ? "  " : $"{matrix[i, j]} ");
                    if (j % 3 == 2)
                        Console.Write("│ ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("└───────┴───────┴───────┘");
        }
    }
}
