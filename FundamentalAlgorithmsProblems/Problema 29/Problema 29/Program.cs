using System;

namespace Problema_29
{
    class Program
    {
        static void Main(string[] args)
        {
            //29.	Generarea şirului lui Fibonacci recursiv

            Console.Write("Numarul de termeni: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Fibonacci(limit, 0, 1);
        }

        static int Fibonacci(int limit, int firstElem, int secondElem)
        {
            if(limit == 0)
            {
                return 0;
            }

            Console.Write(firstElem + " ");
            return Fibonacci(--limit, secondElem, firstElem + secondElem);
        }
    }
}
