using System;

namespace PortofoliuAlgoritmi
{
    internal class NumerePrime
    {
        private static void Main()
        {
            Console.WriteLine(Prime1(13));
            Console.WriteLine(Prime2(13));
            Console.WriteLine(Prime3(13));
            Console.WriteLine(Prime4(13));
        }

        private static bool Prime1(int primeNumber)
        {
            if (primeNumber < 2)
            {
                return false;
            }

            for (int i = 2; i < primeNumber; i++)
            {
                if (primeNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool Prime2(int primeNumber)
        {
            if (primeNumber < 2)
            {
                return false;
            }

            for (int i = 2; i < primeNumber / 2; i++)
            {
                if (primeNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool Prime3(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i * i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool Prime4(int n)
        {
            if (n < 2 || n != 2 && n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i < n; i = i + 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}