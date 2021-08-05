using System;

namespace Problema_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Algoritmul de determinarea numerelor palindrom
            //[Un număr este palindrom dacă în reprezentarea pe cifre acesta are aceeaşi valore citit de la dreapta la stȃnga cȃt şi de la stȃnga la dreapta(11211)]

            string number = ReadData();
            bool isPalindrom = IsPalindrom(number);
            Console.WriteLine($"{isPalindrom}");
        }

        private static bool IsPalindrom(string number)
        {
            for(int i = 0; i < number.Length; i++)
            {
                if(number[i] != number[number.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static string ReadData()
        {
            Console.Write("x=");
            return Console.ReadLine();
        }
    }
}
