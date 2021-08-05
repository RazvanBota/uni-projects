using System;

namespace ConvertorBCD
{
    public class Convertor
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul: ");
            string value = Console.ReadLine();

            Console.WriteLine("Numarul in baza BCD este: " + ConvertToBCD(value));
        }

        public static string ConvertToBCD(string number)
        {
            if (string.Equals(number[0], '+') || string.Equals(number[0], '-'))
                return ConvertWithSign(number);

            return ConvertNumberWithoutSign(number);
        }

        private static string ConvertWithSign(string number)
        {
            char sign = number[0];
            string numberWithoutSign = number.Split(sign)[1];

            if (sign.Equals('+'))
                return "0000 " + ConvertNumberWithoutSign(numberWithoutSign);

            return ConvertWithNegativeSign(numberWithoutSign);
        }

        private static string ConvertWithNegativeSign(string number)
        {
            string complement = (9999 - Convert.ToInt32(number) + 1).ToString();
            return ConvertNumberWithoutSign(complement);
        }

        private static string ConvertNumberWithoutSign(string number)
        {
            string convertedNumber = string.Empty;
            foreach (char digit in number)
                convertedNumber += ConvertDigitToBaseTwo(digit - '0') + " ";

            return convertedNumber;
        }

        private static string ConvertDigitToBaseTwo(int digit)
        {
            string[] convertedDigits = new string[] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001" };
            return convertedDigits[digit];
        }
    }
}
