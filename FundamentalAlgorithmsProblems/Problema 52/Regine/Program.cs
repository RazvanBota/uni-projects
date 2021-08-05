using System;

namespace Regine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[,] table = new int[n, n];

                if (IsSolution(table, n, 0))
                {
                    Print(table, n);
                }
                else
                {
                    Console.WriteLine("Nu avem solutie");
                }
                Console.ReadKey();
            }

            static void Print(int[,] table, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(table[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            static bool IsSolution(int[,] table, int limit, int quens)
            {
                if (quens >= limit)
                {
                    return true;
                }

                for (int actualQuens = 0; actualQuens < limit; actualQuens++)
                {
                    if (IsAvailable(table, limit, quens, actualQuens))
                    {
                        table[actualQuens, quens] = 1;

                        if (IsSolution(table, limit, quens + 1) == true)
                        {
                            return true;
                        }

                        table[actualQuens, quens] = 0;
                    }
                }
                return false;
            }

            static bool IsAvailable(int[,] tabla, int n, int c, int l)
            {
                int i;
                int j;

                for (i = 0; i < c; i++)
                {
                    if (tabla[l, i] == 1)
                    {
                        return false;
                    }
                }

                for (i = l, j = c; i >= 0 && j >= 0; i--, j--)
                {
                    if (tabla[i, j] == 1)
                    {
                        return false;
                    }
                }

                for (i = l, j = c; i < n && j >= 0; i++, j--)
                {
                    if (tabla[i, j] == 1)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}