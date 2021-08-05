using System;
using System.Numerics;

namespace ConvertorBetweenBases
{
    public class Convertor
    {
        static void Main(string[] args)
        {
            Console.Write("Numarul dorit pentru conversie: ");
            string number = Console.ReadLine().ToUpper();

            Console.Write("Baza numarului: ");
            int baseOfNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Baza in care sa fie convertit numarul: ");
            int baseToConvert = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ConvertNumber(number, baseOfNumber, baseToConvert));
        }

        public static string ConvertNumber(string number, int baseOfNumber, int baseToConvert)
        {
            number = ConvertToBaseTen(number, baseOfNumber);
            return ConvertFromBaseTen(number, baseToConvert);
        }

        public static string ConvertToBaseTen(string number, int baseOfNumber)
        {
            bool isComma = number.Contains('.');
            int power = isComma ? number.Split('.')[0].Length - 1 : number.Length - 1;
            float newNumber = 0, numberAfterComma = 0;

            foreach (char digit in number)
            {
                if (digit.Equals('.'))
                    continue;
                if (power >= 0)
                    newNumber += ConvertDigitToBaseTen(digit, baseOfNumber, power--);
                else
                    numberAfterComma += ConvertDigitToBaseTen(digit, baseOfNumber, power--);
            }

            if (isComma)
                return (newNumber + numberAfterComma).ToString().Replace(',', '.');
            return newNumber.ToString();
        }

        public static string ConvertFromBaseTen(string number, int baseToConvert)
        {
            bool isComma = number.Contains('.');
            int convertedNumber = isComma ? Convert.ToInt32(number.Split('.')[0]) : Convert.ToInt32(number);
            string newNumberAfterComma = string.Empty;

            if(isComma)
            {
                newNumberAfterComma = ConvertToNewBaseNumberAfterComma(number.Split('.')[1], baseToConvert);
            }

            string newNumber = string.Empty;
            while (convertedNumber != 0)
            {
                newNumber += ReturnNumberAsChar(convertedNumber % baseToConvert);
                convertedNumber /= baseToConvert;
            }

            if (isComma)
                return RevertNumber(newNumber) + "." + newNumberAfterComma;
            return RevertNumber(newNumber);
        }

        private static string ConvertToNewBaseNumberAfterComma(string number, int newBase)
        {
            float convertedNumber = Convert.ToInt32(number) / (float)Math.Pow(10, number.Length);
            string newNumber = string.Empty;

            while(convertedNumber != 0)
            {
                convertedNumber *= newBase;
                if(convertedNumber > 0)
                {
                    try
                    {
                        int integerPart = Convert.ToInt32(convertedNumber.ToString().Split('.')[0]);
                        newNumber += ReturnNumberAsChar(integerPart);
                        convertedNumber -= integerPart;

                        if (newNumber.Length >= 5 && newBase != 2)
                            return newNumber.Substring(0, 3);
                        if (newBase == 2 && newNumber.Length >= 8)
                            return newNumber.Substring(0, 8);

                    }
                    catch(Exception)
                    {
                        return newNumber.Substring(0, 3);
                    }
                    //if(newNumber.Length > 3 && newNumber.Substring(newNumber.Length - 1).Equals(newNumber.Substring(newNumber.Length - 2, 1)) && newNumber.Substring(newNumber.Length - 1).Equals(newNumber.Substring(newNumber.Length - 3, 1)))
                    //{
                    //    return newNumber.Substring(0, newNumber.Length - 2);
                    //}
                }
            }

            return newNumber;
        }

        private static float ConvertDigitToBaseTen(char digit, int numberBase, int power)
        {
            if (Char.IsLetter(digit))
                return (digit - 'A' + 10) * (float)Math.Pow(numberBase, power);
            return (digit - '0') * (float)Math.Pow(numberBase, power);
        }

        private static string ReturnNumberAsChar(int rest)
        {
            if (rest >= 10)
                return ((char)(rest - 10 + 'A')).ToString();

            return rest.ToString();
        }

        private static string RevertNumber(string number)
        {
            string revertedNumber = string.Empty;

            for(int i = number.Length - 1; i >= 0; i--)
                revertedNumber += number[i];

            return revertedNumber;
        }
    }
}
