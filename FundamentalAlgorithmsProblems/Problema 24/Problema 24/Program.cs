using System;

namespace Problema_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Parcurgerea în spiralǎ a unei matrici
            //  [Constriţi un algoritm de afişare a elementelor unei matrici astfel: se afişează în ordine elementele de pe margine după care se face abstracţie de acestea şi se repetă algoritmul.
            //  11 12 13 14 15
            //  16 17 18 19 20
            //  21 22 23 24 25
            //  26 27 28 29 30
            //  31 32 33 34 35
            //  => (11, 12, 13, 14, 15, 20, 25, 30, 35, 34, 33, 32, 31, 26, 21, 16, 17, 18, 19, 24, 29, 28, 27, 22, 23)]

            Console.Write("Numar de lini: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numar de coloane: ");
            int collumns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = CreateBasicMatrix(lines, lines);

            PrintTheMatrix(matrix, lines, lines);
            CrossingMatrixFromTheOutsideToCenter(matrix, lines, lines);
        }

        static int[,] CreateBasicMatrix(int rows, int columns)
        {
            int firstValue = 11;
            int[,] matrix = new int[rows, columns];

            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    matrix[row, column] = firstValue;
                    firstValue++;
                }
            }

            return matrix;
        }

        static void CrossingMatrixFromTheOutsideToCenter(int[,] matrix, int rows, int columns)
        {
            int crossedRow = 0, crossedColumn = 0;

            while (crossedRow < rows && crossedColumn < columns)
            {
                for (int column = crossedColumn; column < columns; ++column)
                {
                    Console.Write(matrix[crossedRow, column] + " ");
                }
                crossedRow++;

                for (int row = crossedRow; row < rows; ++row)
                {
                    Console.Write(matrix[row, columns - 1] + " ");
                }
                columns--;

                if (crossedRow < rows)
                {
                    for (int column = columns - 1; column >= crossedColumn; --column)
                    {
                        Console.Write(matrix[rows - 1, column] + " ");
                    }
                    rows--;
                }

                if (crossedColumn < columns)
                {
                    for (int row = rows - 1; row >= crossedRow; --row)
                    {
                        Console.Write(matrix[row, crossedColumn] + " ");
                    }
                    crossedColumn++;
                }
            }
        }

        static void PrintTheMatrix(int[,] matrix, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
