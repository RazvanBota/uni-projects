using System;

namespace Problema23
{
    class Program
    {
        static void Main(string[] args)
        {
            //23.Identificarea zonelor din matrice (de o parte şi de alta a diagonalei principale şi secundare)
            //   Constriţi următoarele matrici pătratice de dimensiune n:
            //   1 1 0 2 2      0 1 1 1 0
            //   1 1 0 2 2      4 0 1 0 2
            //   0 0 0 0 0  si  4 4 0 2 2
            //   3 3 0 4 4      4 0 3 0 2
            //   3 3 0 4 4      0 3 3 3 0

            Console.Write("Numar de linii si coloane: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[lines, lines];

            matrix = NorhAndWest(matrix, lines);
            matrix = SouthAndEast(matrix, lines);

            PrintTheMatrix(matrix, lines);

            int[,] secondMatrix = new int[lines, lines];

            secondMatrix = NorthWestAndSouthEast(secondMatrix, lines);
            secondMatrix = NorthEastAndSouthWest(secondMatrix, lines);

            PrintTheMatrix(secondMatrix, lines);
        }

        static int[,] NorhAndWest(int[,] matrix, int numberOfLinesAndRows)
        {
            for(int row = 0; row < numberOfLinesAndRows/2 + 1; row++)
            {
                for(int collumn = row + 1; collumn < numberOfLinesAndRows - row-1; collumn++)
                {
                    matrix[row, collumn] = 1;
                    matrix[collumn, row] = 4;
                }
            }

            return matrix;
        }

        static int[,] SouthAndEast(int[,] matrix, int numberOfLinesAndRows)
        {
            for (int collumn = numberOfLinesAndRows/2 + 1; collumn < numberOfLinesAndRows; collumn++)
            {
                for (int row = numberOfLinesAndRows - collumn; row < numberOfLinesAndRows && row < collumn; row++)
                {
                    matrix[row, collumn] = 2;
                    matrix[collumn, row] = 3;
                }
            }

            return matrix;
        }

        static int[,] NorthWestAndSouthEast(int[,] matrix, int numberOfLinesAndRows)
        {
            for(int row = 0; row < numberOfLinesAndRows / 2; row++)
            {
                for(int collumn = 0; collumn < numberOfLinesAndRows/2; collumn++)
                {
                    matrix[row, collumn] = 1;
                    matrix[numberOfLinesAndRows - row - 1, numberOfLinesAndRows - collumn - 1] = 4;
                }
            }

            return matrix;
        }

        static int[,] NorthEastAndSouthWest(int[,] matrix, int numberOfLinesAndRows)
        {
            for (int row = 0; row < numberOfLinesAndRows / 2; row++)
            {
                for (int collumn = numberOfLinesAndRows / 2 + 1; collumn < numberOfLinesAndRows; collumn++)
                {
                    matrix[row, collumn] = 2;
                    matrix[collumn, row] = 3;
                }
            }

            return matrix;
        }

        static void PrintTheMatrix(int[,] matrix, int numberOfLines)
        {
            for (int line = 0; line < numberOfLines; line++)
            {
                for (int collumn = 0; collumn < numberOfLines; collumn++)
                {
                    Console.Write(matrix[line, collumn]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
