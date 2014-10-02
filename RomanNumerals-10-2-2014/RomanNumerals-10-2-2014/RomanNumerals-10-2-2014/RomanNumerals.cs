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

            //This is basicall a sieve, taking the largest possible numeral on each pass.
            //It's not the most efficent way to do this, but given the small problem size
            //it would take more effort to be elegant than the returns would justify.

            while (numberToConvert > 0)
            {
                if (numberToConvert >= 1000)
                {
                    result += "M";
                    numberToConvert -= 1000;
                }
                else if (numberToConvert >= 900)
                {
                    result += "CM";
                    numberToConvert -= 900;
                }
                else if (numberToConvert >= 500)
                {
                    result += "D";
                    numberToConvert -= 500;
                }
                else if (numberToConvert >= 400)
                {
                    result += "CD";
                    numberToConvert -= 400;
                }
                else if (numberToConvert >= 100)
                {
                    result += "C";
                    numberToConvert -= 100;
                }
                else if (numberToConvert >= 90)
                {
                    result += "XC";
                    numberToConvert -= 90;
                }
                else if (numberToConvert >= 50)
                {
                    result += "L";
                    numberToConvert -= 50;
                }
                else if (numberToConvert >= 40)
                {
                    result += "XL";
                    numberToConvert -= 40;
                }
                else if (numberToConvert >= 10)
                {
                    result += "X";
                    numberToConvert -= 10;
                }
                else if(numberToConvert >= 9)
                {
                    result += "IX";
                    numberToConvert -= 9;
                }
                else if(numberToConvert >= 5)
                {
                    result += "V";
                    numberToConvert -= 5;
                }
                else if(numberToConvert >= 4)
                {
                    result += "IV";
                    numberToConvert -= 4;
                }
                else
                {
                    result += "I";
                    numberToConvert -= 1;
                }
            }

            return result;
            
        }
    }
}
