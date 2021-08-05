using System;

namespace Problema_53
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int[] tokens = { 25, 10, 5, 1 };
            string result = $"{sum} = ";

            int[] resultArray = Calculate(sum, tokens);
            result = GetResultAsString(tokens, resultArray, result);

            Console.WriteLine(result);
        }

        private static int[] Calculate(int sum, int[] tokens)
        {
            int[] resultArray = new int[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                resultArray[i] = sum / tokens[i];
                sum %= tokens[i];
            }

            return resultArray;
        }

        private static string GetResultAsString(int[] tokens, int[] resultArray, string result)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                if (resultArray[i] != 0)
                {
                    result += resultArray[i] + "*" + tokens[i];
                    if (i < tokens.Length - 1)
                    {
                        result += " + ";
                    }
                }
            }

            return result;
        }
    }
}