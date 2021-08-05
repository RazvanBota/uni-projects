using System;

namespace Problema_50
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int lenght = 3;
            int[] array = new int[lenght];
            bool[] boolArray = new bool[lenght];
            int solutions = 0;

            Partitii(lenght, 0, array, boolArray, 0, solutions);
        }

        private static void Partitii(int lenght, int position, int[] array, bool[] boolArray, int permutations, int solutions)
        {
            if (position >= lenght)
            {
                for (int i = 0; i < permutations; i++)
                {
                    bool exists = false;
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == i + 1)
                        {
                            Console.Write((j + 1) + " ");
                            exists = true;
                        }
                    }

                    if (exists)
                    {
                        Console.WriteLine();
                    }

                    solutions++;
                }

                Console.WriteLine("-----------");
            }
            else
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (position == 0 || (position > 0 && Math.Abs(i + 1 - array[position - 1]) <= 1 && !boolArray[i]))
                    {
                        array[position] = i + 1;

                        boolArray[position] = true;
                        if (array[position] > permutations)
                        {
                            permutations = array[position];
                        }

                        Partitii(lenght, position + 1, array, boolArray, permutations, solutions);
                        boolArray[i] = false;
                    }
                }
            }
        }
    }
}