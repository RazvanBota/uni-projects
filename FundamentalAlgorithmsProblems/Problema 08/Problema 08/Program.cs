using System;
using System.Collections.Generic;

namespace Problema_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Algoritmul de calcul a sumei/produsului/normei elementelor unui vector

            List<int> inputData = ReadData();

            Console.WriteLine($"Vectorul are {inputData.Count} elemente.");
            
            int sum = CalculateSum(inputData);
            Console.WriteLine($"Suma elementelor este: {sum}");

            int product = CalculateProduct(inputData);
            Console.WriteLine($"Produsul elementelor este: {product}");
        }

        private static int CalculateProduct(List<int> inputData)
        {
            int product = 1;

            foreach(var digit in inputData)
            {
                product *= digit;
            }

            return product;
        }

        private static int CalculateSum(List<int> inputData)
        {
            int sum = 0;

            foreach(var digit in inputData)
            {
                sum += digit;
            }

            return sum;
        }

        private static List<int> ReadData()
        {
            Console.Write("v[] = ");
            string input = Console.ReadLine();
            List<int> vector = new List<int>();

            foreach(var digit in input.Split(' '))
            {
                vector.Add(int.Parse(digit));
            }

            return vector;
        }
    }
}
