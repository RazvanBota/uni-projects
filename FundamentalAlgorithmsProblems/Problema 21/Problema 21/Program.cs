using System;

namespace Problema_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] firstNumber = ReadNumber(n);

            Console.WriteLine("m = ");
            int m = int.Parse(Console.ReadLine());
            int[] secondNumber = ReadNumber(m);

            int[] sum = Sum(firstNumber, secondNumber, n, m);

            PrintVector(firstNumber);
            Console.Write(" + ");
            PrintVector(secondNumber);
            Console.Write(" = ");
            PrintVector(sum);
        }

        private static void PrintVector(int[] sum)
        {
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
        }

        private static int[] Sum(int[] firstNumber, int[] secondNumber, int n, int m)
        {
            int[] sum = n > m ? new int[n + n] : new int[m + m];
            string firstNumberAsString = "", secondNumberAsString = "";

            for (int i = 0; i < firstNumber.Length; i++)
            {
                firstNumberAsString += firstNumber[i];
            }

            for (int i = 0; i < secondNumber.Length; i++)
            {
                secondNumberAsString += secondNumber[i];
            }

            string sumAsString = (int.Parse(firstNumberAsString) * int.Parse(secondNumberAsString)).ToString();
            int position = 0;

            foreach (var digit in sumAsString)
            {
                sum[position] = int.Parse(digit.ToString());
                position++;
            }

            return sum;
        }

        private static int[] ReadNumber(int n)
        {
            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"v[{i + 1}] = ");
                number[i] = int.Parse(Console.ReadLine());
            }

            return number;
        }
    }
}
