using System;

namespace Problema_18
{
    internal class Program
    {
        static public int n = 4;
        static public int k = 3;
        static public int[] array = new int[n];

        private static void Main(string[] args)
        {
            Arrangement(0);
        }

        public static bool IsSolution(int b)
        {
            if (b == k)
            {
                return true;
            }
            return false;
        }

        public static void Print(int lenght)
        {
            for (int i = 1; i <= lenght; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static bool IsValid(int position)
        {
            for (int i = 0; i < position; i++)
            {
                if (array[i] == array[position])
                {
                    return false;
                }
            }
            return true;
        }

        private static void Arrangement(int position)
        {
            for (int i = 1; i <= n; i++)
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
                        Arrangement(position + 1);
                    }
                }
            }
        }
    }
}