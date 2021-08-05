using System;

namespace Problema_36
{
    internal class Program
    {
        private static int nr = 0;
        private static int line = 5;
        private static int column = 5;
        private static string maxPath = "";
        private static string path = "";

        public static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix(line, column);
            bool[,] boolMatrix = new bool[line, column];

            int nrMax = 0;

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (!boolMatrix[i, j])
                    {
                        nr = 0;
                        path = "";
                        Path(matrix, boolMatrix, i, j, matrix[i, j]);
                        if (nrMax < nr)
                        {
                            nrMax = nr;
                            maxPath = path;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
            Console.WriteLine("Lungime:" + nrMax);
            Console.WriteLine(maxPath);
        }

        public static void Path(int[,] matrix, bool[,] boolMatrix, int line, int column, int val)
        {
            if (line >= 0 && column >= 0 && line < Program.line && column < Program.column && !boolMatrix[line, column] && matrix[line, column] == val)
            {
                boolMatrix[line, column] = true;
                nr++;

                path += $"({line}, {column }) ";

                Path(matrix, boolMatrix, line + 1, column, val);
                Path(matrix, boolMatrix, line, column + 1, val);
                Path(matrix, boolMatrix, line - 1, column, val);
                Path(matrix, boolMatrix, line, column - 1, val);
            }
        }


        public static void PrintMatrix(int[,] a)
        {

            for (int i = 0; i < Program.line; i++)
            {
                for (int j = 0; j < Program.column; j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static int[,] GenerateMatrix(int n, int m, int max = 2)
        {
            return new int[,]
            {
                {1, 1, 9, 4, 1},
                {6, 7, 8, 9, 0},
                {1, 2, 2, 9, 5},
                {1, 1, 2, 9, 0},
                {3, 1, 3, 9, 9}
            };
        }
    }
}