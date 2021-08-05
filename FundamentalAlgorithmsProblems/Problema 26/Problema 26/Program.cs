using System;

namespace Problema_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //26.	Produsul a două matrici

            Console.Write("Numarul de linii: ");
            int nrOfLines = Convert.ToInt32(Console.ReadLine());

            int[,] firstMatrix = CreateBasicMatrix(nrOfLines);
            int[,] secondMatrix = CreateBasicMatrix(nrOfLines);

            ShowMatrix(MultiplyMatrixs(firstMatrix, secondMatrix, nrOfLines), nrOfLines);
        }

        static int[,] CreateBasicMatrix(int nrOfLines)
        {
            int[,] matrix = new int[nrOfLines, nrOfLines];
            int firstValueFromMatrix = 1;

            for (int line = 0; line < nrOfLines; line++)
            {
                for (int collumn = 0; collumn < nrOfLines; collumn++)
                {
                    matrix[line, collumn] = firstValueFromMatrix;
                    firstValueFromMatrix++;
                }
            }

            return matrix;
        }

        static int[,] MultiplyMatrixs(int[,] firstMatrix, int[,] secondMatrix, int nrOfLine)
        {
            int[,] multiplyOfTheMatrixs = new int[nrOfLine, nrOfLine];
            int rowOfNewMatrix = 0, columnOfNewMatrix = 0;

            for (int line = 0; line < nrOfLine; line++)
            {
                int sum = 0;
                for (int column = 0; column < nrOfLine; column++)
                {
                    for (int element = 0; element < nrOfLine; element++)
                    {
                        sum += firstMatrix[line, element] * secondMatrix[element, column];
                    }

                    multiplyOfTheMatrixs[rowOfNewMatrix, columnOfNewMatrix++] = sum;
                    sum = 0;
                }

                columnOfNewMatrix = 0;
                rowOfNewMatrix++;
            }

            return multiplyOfTheMatrixs;
        }

        static void ShowMatrix(int[,] matrix, int nrOfLine)
        {
            for (int line = 0; line < nrOfLine; line++)
            {
                for (int collumn = 0; collumn < nrOfLine; collumn++)
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
