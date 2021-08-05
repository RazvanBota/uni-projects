using System;
using System.Collections.Generic;

namespace Problema_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstVector = ReadData();
            List<int> secondVector = ReadData();

            List<int> reunion = UnitTwoVectors(firstVector, secondVector);
            PrintData(reunion);
        }

        private static void PrintData(List<int> reunion)
        {
            foreach(var digit in reunion)
            {
                Console.Write($"{digit} ");
            }
        }

        private static List<int> UnitTwoVectors(List<int> firstVector, List<int> secondVector)
        {
            List<int> newVector = firstVector;

            foreach (int digit in secondVector)
            {
                if (!ContainsValue(digit, firstVector))
                {
                    newVector.Add(digit);
                }
            }

            return newVector;
        }

        private static bool ContainsValue(int input, List<int> vector)
        {
            foreach(var digit in vector)
                if (input.Equals(digit))
                    return true;

            return false;
        }

        private static List<int> ReadData()
        {
            Console.Write("v[] = ");
            string input = Console.ReadLine();

            List<int> vector = new List<int>();

            foreach (string value in input.Split(" "))
            {
                vector.Add(int.Parse(value));
            }

            return vector;
        }
    }
}
