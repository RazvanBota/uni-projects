using System;

namespace Problema_33
{
    internal class Program
    {
        private static void Main()
        {
            Hanoi(3, 'a', 'b', 'c');
        }

        private static void Hanoi(int n, char A, char B, char C)
        {
            if (n == 1)
                Console.WriteLine(A + "->" + C);
            else
            {
                Hanoi(n - 1, A, C, B);
                Hanoi(1, A, B, C);
                Hanoi(n - 1, B, A, C);
            }
        }
    }
}