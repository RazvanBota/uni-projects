using System;

namespace Problema_40
{
    internal class Program
    {
        private static void Main()
        {
            string simbol = "AB";
            int[] pondere = { 1, 4 };

            for (int i = 0; i < 100; i++)
            {
                int A = 0, B = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (MonteCarlo(simbol, pondere) == "A")
                    {
                        A++;
                    }
                    else
                    {
                        B++;
                    }
                }

                Console.WriteLine("A={0},B={1}", A, B);
            }
        }


        private static string MonteCarlo(string simbol, int[] ponderi)
        {
            int n = simbol.Length, p = ponderi.Length;
            if (n != p)
            {
                return null;
            }

            int sum = 0, i;
            for (i = 0; i < p; i++)
            {
                sum += ponderi[i];
            }

            Random rnd = new Random();
            int val = rnd.Next(0, sum);
            int sp = 0;
            for (i = 0; i < n && sp < val; sp += ponderi[i], i++) ;
            if (i == 0)
            {
                i = 1;
            }

            return simbol[i - 1].ToString();
        }
    }
}