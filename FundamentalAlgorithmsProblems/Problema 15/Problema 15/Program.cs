using System;

namespace Problema_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //15.	Concatenarea a doi vectori

            int[] firstVector = ReadData();
            int[] secondVector = ReadData();
            int[] concatenatedVectors = ConcatenateVectors(firstVector, secondVector);
            PrintVector(concatenatedVectors);
        }

        private static void PrintVector(int[] concatenatedVectors)
        {
            Console.WriteLine();
            Console.WriteLine("Vectori concatenati sunt:");
            foreach(var digit in concatenatedVectors)
            {
                Console.Write($"{digit} ");
            }
        }

        private static int[] ConcatenateVectors(int[] firstVector, int[] secondVector)
        {
            int[] newVector = new int[firstVector.Length + secondVector.Length];
            int position = 0;

            foreach(var digit in firstVector)
            {
                newVector[position++] = digit;
            }

            foreach(var digit in secondVector)
            {
                newVector[position++] = digit;
            }

            return newVector;
        }

        private static int[] ReadData()
        {
            Console.Write("v[] = ");
            string inputValues = Console.ReadLine();
            int[] vector = new int[inputValues.Split(' ').Length];
            int count = 0;

            foreach (var digit in inputValues.Split(' '))
            {
                vector[count++] = int.Parse(digit);
            }

            return vector;
        }
    }
}
