using System;

namespace Problema_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //28.	Implementarea funcţiei factorial recursiv

            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( Factorial(x) );
        }

        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(--number);
        }
    }
}
