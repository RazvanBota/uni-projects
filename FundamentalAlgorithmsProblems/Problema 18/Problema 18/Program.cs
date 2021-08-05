using System;

namespace Problema_18
{
    internal class Program
    {
        private static void Main()
        {
            int[] a = new int[] { 3, 2 };
            int[] b = new int[] { 2 };

            Console.WriteLine(string.Join(" ", Diferenta(a, b)));

            return;
        }

        private static int[] Diferenta(int[] firstVector, int[] secondVector)
        {
            int[] differencVector = new int[firstVector.Length];
            int nr = 0;

            for (int i = 0; i < firstVector.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < secondVector.Length && !found; j++)
                    if (secondVector[j] == firstVector[i])
                        found = true;
                if (!found)
                    differencVector[nr++] = firstVector[i];
            }

            int[] newDifferenceVector = new int[nr];

            for (int i = 0; i < nr; i++)
                newDifferenceVector[i] = differencVector[i];

            return newDifferenceVector;
        }
    }
}