using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndAdd
{
    public class ReverseAndAdd
    {
        public string ReverseNumberAsString(string input)
        {
            string forward = input;
            char[] charArray = forward.ToCharArray();
            Array.Reverse(charArray);
            string backward = new String(charArray);
                        
            return backward;
        }

        public string AddTwoNumberStrings(string forward, string backward)
        {
            int forwardAsInt = Convert.ToInt32(forward);
            int backwardAsInt = Convert.ToInt32(backward);
            int result = forwardAsInt + backwardAsInt;

            string resultAsString = result.ToString();
            return resultAsString;
       }
    }
}
