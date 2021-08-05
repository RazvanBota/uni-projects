using System;

namespace Problema_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Construirea matricii de dimensiune n*m a primelor n*m numere prime
            //  Ex(n = 3, m = 3):
            //   2  3   5
            //   7  11  13
            //   17 19  23

            int numberOfLine, numberOfCollumns, primeNumber = 2;

            Console.Write("Numar de linii: ");
            numberOfLine = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numar de coloane: ");
            numberOfCollumns = Convert.ToInt32(Console.ReadLine());

            for (int linie = 0; linie < numberOfLine; linie++)
            {
                for (int coloana = 0; coloana < numberOfCollumns; coloana++)
                {
                    Console.Write($"{primeNumber} ");

                    primeNumber = GetNextPrimeNumber(primeNumber);
                }
                Console.WriteLine();
            }
        }

        static int GetNextPrimeNumber(int actualNumber)
        {
            actualNumber++;
            while (true)
            {
                if (IsPrime(actualNumber))
                {
                    return actualNumber;
                }

                actualNumber++;
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 3)
            {
                return true;
            }

            for (int i = 2; i <= number/2; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
