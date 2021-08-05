using System;

namespace Problema_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //25.	Suma a două matrici

            Console.Write("Numarul de linii: ");
            int nrOfLines = Convert.ToInt32(Console.ReadLine());

            int[,] firstMatrix = CreateBasicMatrix(nrOfLines);
            int[,] secondMatrix = CreateBasicMatrix(nrOfLines);

            ShowMatrix(SumOfMatrixs(firstMatrix, secondMatrix, nrOfLines), nrOfLines);
        }

        static int[,] CreateBasicMatrix(int nrOfLines)
        {
            int[,] matrix = new int[nrOfLines, nrOfLines];
            int firstValueFromMatrix = 1;

            for (int line = 0; line < nrOfLines; line++)
            {
                for(int collumn = 0; collumn < nrOfLines; collumn++)
                {
                    matrix[line, collumn] = firstValueFromMatrix;
                    firstValueFromMatrix++;
                }
            }

            return matrix;
        }

        static int[,] SumOfMatrixs(int[,] firstMatrix, int[,] secondMatrix, int nrOfLine)
        {
            int[,] sumOfTheMatrixs = new int[nrOfLine, nrOfLine];

            for(int line = 0; line < nrOfLine; line++)
            {
                for(int collumn = 0; collumn < nrOfLine; collumn++)
                {
                    sumOfTheMatrixs[line, collumn] = firstMatrix[line, collumn] + secondMatrix[line, collumn];
                }
            }

            return sumOfTheMatrixs;
        }

        static void ShowMatrix(int[,] matrix, int nrOfLine)
        {
            for(int line = 0; line < nrOfLine; line++)
            {
                for(int collumn = 0; collumn < nrOfLine; collumn++)
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
