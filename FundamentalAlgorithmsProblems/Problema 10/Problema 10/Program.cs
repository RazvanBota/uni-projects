using System;

namespace Program
{
    internal class Program
    {
        private static void Main()
        {
            int[] a = RandomArray(10, -100, 100);

            Console.WriteLine("a=({0})", string.Join(",", a));

            SignSort(a);

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

        private static void SignSort(int[] array)
        {
            int neg = 0, zero = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    if (zero != 0)
                    {
                        array[neg] = array[i];
                        array[i] = array[neg + zero];
                        array[neg + zero] = 0;
                    }
                    else
                    {
                        int aux = array[i];
                        array[i] = array[neg];
                        array[neg] = aux;
                    }

                    neg++;
                }
                else if (array[i] == 0)
                {
                    int aux = array[neg + zero];
                    array[neg + zero] = array[i];
                    array[i] = aux;
                    zero++;
                }
            }
        }
    }
}