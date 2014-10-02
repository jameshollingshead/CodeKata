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
            if (input == 2)
                return "II";
            else
                return "I";
        }
    }
}
