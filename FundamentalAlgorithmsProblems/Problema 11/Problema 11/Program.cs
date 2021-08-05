using System;

namespace Problema_11
{
    class Program
    {
        static void Main()
        {
            int[] a = RandomArray(10, -100, 100);
            Console.WriteLine("a=({0})", string.Join(",", a));

            BubbleSort(a);
            Console.WriteLine("a=({0})", string.Join(",", a));
        }

        private static int[] RandomArray(int n, int min = 0, int max = 100)
        {
            Random rnd = new Random();
            int[] toReturn = new int[n];

            for (int i = 0; i < toReturn.Length; i++)
            {
                toReturn[i] = rnd.Next(min, max + 1);
            }

            return toReturn;
        }

        static void BubbleSort(int[] a)
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < a.Length - 1; i++)
                    if (a[i] > a[i + 1])
                    {
                        int aux = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = aux;
                        sorted = false;
                    }
            } while (!sorted);
        }
    }
}
