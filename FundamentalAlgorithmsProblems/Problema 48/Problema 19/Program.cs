using System;

namespace Problema_19
{
    internal class Program
    {
        static public int n = 9;
        static public int k = 5;
        static public int[] array = new int[n];

        private static void Main(string[] args)
        {
            Combinations(1);
        }

        public static void Print(int lenght)
        {
            for (int i = 1; i <= lenght; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Combinations(int position)
        {
            for (int i = position; i <= n; i++)
            {
                array[position] = i;
                if (IsValid(position))
                {
                    if (IsSolution(position))
                    {
                        Print(position);
                    }
                    else
                    {
                        Combinations(position + 1);
                    }
                }
            }
        }

        private static bool IsSolution(int position)
        {
            if (position == k)
            {
                return true;
            }
            return false;
        }

        private static bool IsValid(int position)
        {
            for (int i = 0; i < position; i++)
            {
                if (array[i] == array[position] || array[i] > array[position])
                {
                    return false;
                }
            }
            return true;
        }
    }
}