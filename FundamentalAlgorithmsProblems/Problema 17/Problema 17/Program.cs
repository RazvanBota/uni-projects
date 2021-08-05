using System;
using System.Collections.Generic;

namespace Problema_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstVector = ReadData();
            List<int> secondVector = ReadData();

            List<int> intersection = GetIntersection(firstVector, secondVector);
            PrintVector(intersection);
        }

        private static void PrintVector(List<int> intersection)
        {
            foreach(var digit in intersection)
            {
                Console.Write($"{digit} ");
            }
        }

        private static List<int> GetIntersection(List<int> firstVector, List<int> secondVector)
        {
            List<int> intersection = new List<int>();

            foreach(var digit in firstVector)
            {
                if(secondVector.Contains(digit))
                {
                    intersection.Add(digit);
                }
            }

            return intersection;
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
