using System;
using System.Collections.Generic;

namespace Problema_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Algoritmul de determinare a minimului dintr-o mulţime introdusă secvenţial
            //   [Se citesc de la tastaură o serie de numere pȃnă cȃnd se introduce o valoare dată(-1). 
            //   Să se afişeze minimul valorilor citite, şi eventual numărul de apariţie a acestei valori]
            List<int> input = ReadInputData();
            ExecuteProgram(input);
        }

        private static void ExecuteProgram(List<int> input)
        {
            int countOccurrences = 0, minimalValue = int.MaxValue;
            
            foreach(var data in input)
            {
                if (data == minimalValue)
                {
                    countOccurrences++;
                }

                if (data < minimalValue)
                {
                    minimalValue = data;
                    countOccurrences = 1;
                }
            }

            Console.WriteLine($"Numarul minim este: {minimalValue} si numarul de aparitie este: {countOccurrences}");
        }

        private static List<int> ReadInputData()
        {
            List<int> values = new List<int>();

            while(true)
            {
                Console.Write("Adauga valoare: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == -1)
                {
                    return values;
                }

                values.Add(input);
            }
        }
    }
}
