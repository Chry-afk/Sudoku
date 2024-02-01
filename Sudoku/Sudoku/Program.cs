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
            Console.WriteLine(sudoku.checkMatrix());
            Console.ReadKey();
        }
        
    }

    class Sudoku
    {
        int[,] matrix =
            {
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                { '0', '0', '0', '0', '0', '0', '0', '0', '0' }
            };

        // metodo che controlla se la matrice è corretta o errata
        public bool checkMatrix()
        {
            for (int number = 1; number <= 9; number++) {
                for (int i = 0; i < 9; i++)
                {
                    int[] rigaArray = new int[9];
                    for (int j = 0; j < 9; j++)
                    {
                        rigaArray[j] = matrix[i, j];
                    }
                    if (rigaArray.Contains(number)) return true;
                }

                for (int i = 0; i < 9; i++)
                {
                    int[] colonnaArray = new int[9];
                    for (int j = 0; j < 9; j++)
                    {
                        colonnaArray[j] = matrix[j, i];
                    }
                    if (colonnaArray.Contains(number)) return true;
                }
            }
            return false;
        }

        public bool insert(int number, int x, int y)
        {
            if (x<10 && x>0 && y < 10 && y > 0)
            {
                matrix[x, y] = number;
            }
            return false;
        }
    }
}
