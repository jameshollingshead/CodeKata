using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals_10_2_2014
{
    public class RomanNumerals
    {
        public string ConvertArabicToRomanNumerals(int input)
        {
            string result = string.Empty;
            int numberToConvert = input;
            string[] romanNumerals = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] arabicNumerals = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int conversionArrayLength = romanNumerals.Length;

            //This is basicall a sieve, taking the largest possible numeral on each pass.
            //It's not the most efficent way to do this, but given the small problem size
            //it would take more effort to be elegant than the returns would justify.

            while (numberToConvert > 0)
            {
                bool convertedNumber = false;

                for(int i = 0; i < conversionArrayLength && convertedNumber == false; i++)
                {
                    if(numberToConvert >= arabicNumerals[i])
                    {
                        result += romanNumerals[i];
                        numberToConvert -= arabicNumerals[i];
                        convertedNumber = true;
                    }
                }
            }

            return result;
            
        }
    }
}
