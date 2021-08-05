using System;

namespace Patratul_magic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix(3);
            Print(matrix);

            DoMagic(matrix);

            Print(matrix);
        }

        private static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int number = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = number;
                    number++;
                }
            }

            return matrix;
        }

        private static bool IsMagic(int[,] matrix)
        {
            int line1 = matrix[0, 0] + matrix[0, 1] + matrix[0, 2];
            int line2 = matrix[1, 0] + matrix[1, 1] + matrix[1, 2];
            int line3 = matrix[2, 0] + matrix[2, 1] + matrix[2, 2];
            int col1 = matrix[0, 0] + matrix[1, 0] + matrix[2, 0];
            int col2 = matrix[0, 1] + matrix[1, 1] + matrix[2, 1];
            int col3 = matrix[0, 2] + matrix[1, 2] + matrix[2, 2];
            int firstlDiag1 = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
            int secondDiag2 = matrix[2, 0] + matrix[1, 1] + matrix[0, 2];

            if ((line1 == line2) && (line1 == line3) && (line1 == col1) && (line1 == col2) && (line1 == col3) && (line1 == firstlDiag1) && (line1 == secondDiag2))
            {
                return true;
            }

            return false;
        }

        private static void DoMagic(int[,] m)
        {
            while (!IsMagic(m))
            {
                Rearrange(m);
            }
        }

        private static void Print(int[,] m)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] Rearrange(int[,] m)
        {
            Random rnd = new Random();
            int line1 = rnd.Next(3);
            int col1 = rnd.Next(3);
            int line2 = rnd.Next(3);
            int col2 = rnd.Next(3);

            int aux = m[line1, col1];
            m[line1, col1] = m[line2, col2];
            m[line2, col2] = aux;

            return m;
        }
    }
}