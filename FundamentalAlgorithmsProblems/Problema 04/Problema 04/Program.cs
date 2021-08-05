using System;

namespace Problema_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.	Algoritmul de determinare a cifrelor unui numǎr
            string inputValue = ReadData();
            DeterminDigit(inputValue);
        }

        private static string ReadData()
        {
            Console.WriteLine("Numarul este:");
            return Console.ReadLine();
        }

        private static void DeterminDigit(string inputValue)
        {
            int[] digits = new int[10];

            foreach (var digit in inputValue)
            {
                if(digit < '0' || digit > '9')
                {
                    Console.WriteLine("Numerul nu este valid");
                    return;
                }

                digits[digit - '0']++;
            }

            ShowDigits(digits);
        }

        private static void ShowDigits(int[] digits)
        {
            for(int i = 0; i < 10; i++)
            {
                if (digits[i] != 0)
                    Console.Write($"{i} ");
            }
        }
    }
}
