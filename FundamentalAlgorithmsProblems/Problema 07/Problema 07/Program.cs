using System;

namespace Problema_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Algoritmul lui Euclid

            int a = ReadData("a"); 
            int b = ReadData("b");
            int euclid = Euclid(a, b);

            Console.WriteLine($"{euclid}");
        }

        private static int ReadData(string variable)
        {
            Console.Write($"{variable}=");
            return int.Parse(Console.ReadLine());
        }

        private static int Euclid(int firstValue, int secondValue)
        {
            int aux;
            
            while (secondValue != 0)
            {
                aux = firstValue % secondValue;
                firstValue = secondValue;
                secondValue = aux;
            }

            return firstValue;
        }
    }
}
