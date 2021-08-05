using System;

namespace Problema_37
{
    internal class Program
    {
        private static int rows = 5, columns = 5, lg1 = 0, lg2 = 0, lg = 0;
        private static bool terrain1, terrain2;

        private static void Main()
        {
            int[,] matrix = GenerateMatrix();
            PrintMatrix(matrix);

            bool[,] boolMatrix = new bool[rows, columns];
            for (int line = 0; line < rows; line++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (!boolMatrix[line, col] && matrix[line, col] == 0)
                    {
                        lg = 0;
                        terrain1 = terrain2 = false;

                        Terain(matrix, boolMatrix, line, col);
                        if (terrain1 || terrain2)
                        {
                            if (terrain1)
                            {
                                lg1 += lg;
                            }

                            if (terrain2)
                            {
                                lg2 += lg;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Teritoriu de 1 : " + lg1);
            Console.WriteLine("Teritoriu de 2 : " + lg2);

            return;
        }

        private static int[,] GenerateMatrix()
        {
            return new int[,]
            {
                { 1, 1, 9, 4, 1 },
                { 6, 7, 8, 9, 0 },
                { 1, 2, 2, 9, 5 },
                { 1, 1, 2, 9, 0 },
                { 3, 1, 3, 9, 9 }
            };
        }

        private static void Terain(int[,] matrix, bool[,] boolMatrix, int line, int col)
        {
            if (line >= 0 && col >= 0 && line < rows && col < columns && !boolMatrix[line, col])
            {
                if (matrix[line, col] == 1)
                {
                    terrain1 = true;
                }
                else if (matrix[line, col] == 2)
                {
                    terrain2 = true;
                }
                else
                {
                    lg++;
                    boolMatrix[line, col] = true;
                    Terain(matrix, boolMatrix, line + 1, col);
                    Terain(matrix, boolMatrix, line, col + 1);
                    Terain(matrix, boolMatrix, line - 1, col);
                    Terain(matrix, boolMatrix, line, col - 1);
                }
            }
        }

        private static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}