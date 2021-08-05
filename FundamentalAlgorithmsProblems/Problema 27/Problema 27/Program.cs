using System;

namespace Problema_27
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] a, b;
            a = CitireMatriceA();
            b = CitireMatriceB();

            Afisare(a);
            Afisare(b);

            bool inc = Incluziune2(a, b);
            Console.WriteLine("{0}", inc ? "Da" : "Nu");
        }

        private static bool Incluziune2(int[,] a, int[,] b)
        {
            int na = a.GetLength(0), ma = a.GetLength(1);
            int nb = b.GetLength(0), mb = b.GetLength(1);

            bool inclus = false;
            int ib = 0, jb = 0;

            for (int i = 0; i < na && !inclus; i++)
            {
                for (int j = 0; j < ma && !inclus; j++)
                {
                    if (a[i, j] == b[ib, jb] && a[i - ib, j - jb] == b[0, 0])
                    {
                        jb++;
                        if (jb >= mb)
                        {
                            jb = 0;
                            ib++;
                            if (ib >= nb)
                                inclus = true;
                        }
                    }
                    else if (a[i, j] != b[ib, jb] && a[i - ib, j - jb] == b[0, 0])
                    {
                        jb = 0;
                        ib = 0;
                        j--;
                    }
                }
            }
            return inclus;
        }

        private static int[,] CitireMatriceA()
        {
            return new int[,]
            {
                {3, 8, 9, 7, 8, 9},
                {0, 3, 4, 5, 0, 0},
                {2, 7, 8, 9, 3, 4},
                {0, 0, 0, 0, 7, 8},
                {4, 5, 0, 0, 0, 0},
                {7, 8, 9, 3, 4, 5},
                {0, 0, 0, 7, 8, 9},
                {0, 0, 0, 0, 0, 0}
            };
        }


        private static int[,] CitireMatriceB()
        {
            return new int[,]
            {
                {3, 4, 5},
                {7, 8, 9},
                {0, 0, 0}
            };
        }

        static void Afisare(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}