using System;

namespace Problema_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next() % 100;
            }

            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine(Minim(array, 0, n - 1));
        }

        static int Minim(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                int min1 = Minim(array, left, mid - 1);
                int min2 = Minim(array, mid + 1, right);

                return Math.Min(min1, min2);
            }
            else
            {
                return array[left];
            }
        }
    }
}
