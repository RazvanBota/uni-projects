using System;
using System.Collections.Generic;

namespace Problema_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.	Algoritmul de calcul a minimului/maximului elementelor unui vector

            List<int> inputData = ReadData();
            int minValue = FindMinValue(inputData);
            int maxValue = FindMaxValue(inputData);

            Console.WriteLine($"Valoare minima este {minValue} si cea maxima este {maxValue}");
        }

        private static int FindMaxValue(List<int> inputData)
        {
            int max = int.MinValue;

            foreach(var digit in inputData)
            {
                if (digit > max)
                    max = digit;
            }

            return max;
        }

        private static int FindMinValue(List<int> inputData)
        {
            int min = int.MaxValue;
            
            foreach(var digit in inputData)
            {
                if(digit < min)
                    min = digit;
            }

            return min;
        }

        private static List<int> ReadData()
        {
            Console.Write("v[] = ");
            string inputValues = Console.ReadLine();
            List<int> vector = new List<int>();

            foreach(var digit in inputValues.Split(' '))
            {
                vector.Add(int.Parse(digit));
            }

            return vector;
        }
    }
}
