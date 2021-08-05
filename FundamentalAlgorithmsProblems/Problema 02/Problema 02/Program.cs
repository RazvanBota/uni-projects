using System;
using System.Collections.Generic;

namespace Problema_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Implementarea problemelor ce ţin de numărul de elemente identice într-o mulţime (1,3,4,1,1) = 3 bucăţi
            //    [Se dau 5 valori întregi a,b,c,d şi e. Construiţi un algoritm care identifică următoarele cazuri: 
            //    1.) Există 2 valori identice, 
            //    2.) Există 2 cȃte 2 valori identice, 
            //    3.) Există 3 valori identice, 
            //    4.) Există 3valori identice şi celelalte 2 sunt de asemena identice, 
            //    5.) Există 4 valori identice şi 
            //    6.) Toate valorile sunt identice] 

            List<int> inputData = ReadInputData();

            if (AllDataAreIdentical(inputData))
            {
                Console.WriteLine("Toate valorile sunt identice.");
            }
            else if (ExistFourIdenticalData(inputData))
            {
                Console.WriteLine("4 valori sunt identice.");
            }
            else if(ExistThreeIdenticalData(inputData) && ExistsTwoIdenticalData(inputData))
            {
                Console.WriteLine("3 valori sunt identice si celelalte 2 sunt identice intre ele.");
            }
            else if (ExistThreeIdenticalData(inputData))
            {
                Console.WriteLine("Doar 3 valori sunt identice.");
            }
            else if (ExistTwoByTwoIdenticalData(inputData))
            {
                Console.WriteLine("Valorile sunt identice 2 cate 2.");
            }
            else if (ExistsTwoIdenticalData(inputData))
            {
                Console.WriteLine("Exista doar 2 valori identice.");
            }
            else
            {
                Console.WriteLine("Nu exista valori identice.");
            }
        }

        private static List<int> ReadInputData()
        {
            Console.WriteLine("Vectorul este: ");
            string inputData = Console.ReadLine();
            List<int> array = new List<int>();

            foreach (string data in inputData.Split(" "))
            {
                array.Add(Convert.ToInt32(data));
            }

            return array;
        }

        private static bool ExistsTwoIdenticalData(List<int> inputData)
        {
            for (int i = 0; i < inputData.Count - 1; i++)
            {
                if(i > 0 && i < inputData.Count - 2 && inputData[i] == inputData[i-1])
                {
                    i++;
                }

                int countValue = 0;
                for (int j = i + 1; j < inputData.Count; j++)
                    if (inputData[i] == inputData[j])
                        countValue++;
                if (countValue == 1)
                    return true;
            }
            return false;
        }

        private static bool ExistThreeIdenticalData(List<int> inputData)
        {
            int countTheSameValue = 0;
            for (int i = 0; i < inputData.Count - 1; i++)
            {
                for (int j = i + 1; j < inputData.Count; j++)
                    if (inputData[i] == inputData[j])
                        countTheSameValue++;
                if (countTheSameValue == 2)
                    return true;
            }

            return false;
        }

        private static bool ExistTwoByTwoIdenticalData(List<int> inputData)
        {
            int valueWithAnotherCopy = 0;
            for(int i = 0; i < inputData.Count-1; i++)
            {
                int countTheSameValue = 0;
                for (int j = i+1; j < inputData.Count; j++)
                    if(inputData[i] == inputData[j])
                        countTheSameValue++;

                if (countTheSameValue == 1)
                    valueWithAnotherCopy++;
            }

            return valueWithAnotherCopy == 2;
        }

        private static bool ExistFourIdenticalData(List<int> inputData)
        {
            for(int i = 0; i < inputData.Count - 1; i++)
            {
                int countValue = 0;
                for(int j = i+1; j < inputData.Count; j++)
                {
                    if (inputData[i] == inputData[j])
                        countValue++;
                }
                if (countValue == 3)
                    return true;
            }
            return false;
        }

        private static bool AllDataAreIdentical(List<int> inputData)
        {
            for(int i = 1; i < 5; i++)
            {
                if (inputData[i] != inputData[1])
                    return false;
            }

            return true;
        }
    }
}
