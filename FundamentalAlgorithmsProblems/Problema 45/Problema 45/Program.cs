using System;

namespace Problema_45
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 20);
            int power = rnd.Next(0, 5);
            
            Console.WriteLine(number + " " + power);
            Console.WriteLine(Putere(number, power));
        }

        private static int Putere(int number, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            if (pow == 1)
            {
                return number;
            }
            else if (pow % 2 == 0)
            {
                return number * Putere(number, pow / 2);
            }
            else
            {
                return number * Putere(number, pow - 1);
            }
        }
    }
}