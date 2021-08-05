using System;

namespace Problema_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] smallVector = ReadVector(n);

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            int[] biggerVector = ReadVector(m);

            int counter = CountVectorAparitions(smallVector, biggerVector, n, m);
            Console.WriteLine($"{counter} aparitii ale vectorului");
        }

        private static int CountVectorAparitions(int[] smallVector, int[] biggerVector, int smallVectorLenght, int biggerVectorLenght)
        {
            int vectorCounter = 0;
            for(int i = 0; i < biggerVectorLenght - smallVectorLenght + 1; i++)
            {
                if(biggerVector[i] == smallVector[0])
                {
                    if(IsEntireVector(biggerVector, i, smallVector, smallVectorLenght))
                    {
                        vectorCounter++;
                        i += smallVectorLenght - 1;
                    }
                }
            }

            return vectorCounter;
        }

        private static bool IsEntireVector(int[] biggerVector, int biggerVectorStartPosition, int[] smallVector, int smallVectorLenght)
        {
            for(int i = 0; i < smallVectorLenght; i++)
            {
                if(smallVector[i] != biggerVector[biggerVectorStartPosition])
                {
                    return false;
                }

                biggerVectorStartPosition++;
            }

            return true;
        }

        private static int[] ReadVector(int n)
        {
            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"v[{i}] = ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            return vector;
        }
    }
}
