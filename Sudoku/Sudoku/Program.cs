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

            Console.ReadKey();
        }
        
    }

    class Sudoku
    {
        public int[,] matrix =
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j]}  "); // Stampa l'elemento seguito da un tab
                }
                sb.AppendLine(); // Vai a capo dopo ogni riga
            }
            return sb.ToString();
        }
    }
}
