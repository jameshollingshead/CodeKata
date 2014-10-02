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

            for (int i = input; i > 0; )
            {
                if(i >= 5)
                {
                    result += "V";
                    i -= 5;
                }
                else if(i >= 4)
                {
                    result += "IV";
                    i -= 4;
                }
                else if (i >= 1)
                {
                    result += "I";
                    i -= 1;
                }
            }

            return result;
            
        }
    }
}
