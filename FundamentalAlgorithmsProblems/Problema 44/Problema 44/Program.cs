using System;

namespace Problema_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int n = array.Length;
            int value = 5;

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next() % 10;
            }

            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(BS(array, 0, n - 1, value));
        }

        static bool BS(int[] v, int st, int dr, int x)
        {
            int m = (st + dr) / 2;
            if (st < dr)
            {
                if (v[m] == x)
                {
                    return true;
                }
                else if (v[m] > x)
                {
                    return BS(v, st, m - 1, x);
                }
                else if (v[m] < x)
                {
                    return BS(v, m + 1, dr, x);
                }
            }

            return false;

        }
    }
}
