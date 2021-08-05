using System;

namespace Problema_34
{
    class Program
    {
        static void Main()
        {
            Hanoi(4, 'a', 'b', 'c', 'd');
        }

        static void Hanoi(int n, char A, char B, char C, char D)
        {
            if (n == 1)
                Console.WriteLine(A + "->" + D);
            else if (n == 2)
            {
                Console.WriteLine(A + "->" + B);
                Console.WriteLine(A + "->" + D);
                Console.WriteLine(B + "->" + D);
            }
            else
            {
                Hanoi(n - 2, A, C, D, B);
                Hanoi(1, A, B, D, C);
                Hanoi(1, A, B, C, D);
                Hanoi(1, C, A, B, D);
                Hanoi(n - 2, B, A, C, D);
            }
        }
    }
}
