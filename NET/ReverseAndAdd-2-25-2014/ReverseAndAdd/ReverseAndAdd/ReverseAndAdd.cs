using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


[assembly: InternalsVisibleTo("ReverseAndAdd.UnitTests")]
namespace ReverseAndAdd
{
    public class ReverseAndAdd
    {
        internal string ReverseString(string input)
        {
            string forward = input;
            char[] charArray = forward.ToCharArray();
            Array.Reverse(charArray);
            string backward = new String(charArray);
                        
            return backward;
        }

        internal string AddTwoNumberStrings(string forward, string backward)
        {
            long forwardAsLong = Convert.ToInt64(forward);
            long backwardAsLong = Convert.ToInt64(backward);
            long result = forwardAsLong + backwardAsLong;

            string resultAsString = result.ToString();
            return resultAsString;
       }

        public bool IsPalindrome(string palindromeCandidate)
        {
            string forward = palindromeCandidate;
            string backward = ReverseString(forward);
            
            return (forward == backward);
        }

        public Palindrome FindPalindrome(string input)
        {
            Palindrome palindrome = new Palindrome();
            string forward = input;
            string backward;
            string palindromeCandidate;
            int i = 0;
            bool isPalindrome = false;

            do
            {
                backward = ReverseString(forward);
                palindromeCandidate = AddTwoNumberStrings(forward, backward);
                forward = palindromeCandidate;
                i++;
                isPalindrome = IsPalindrome(forward);
            } while (i <= 100 && isPalindrome == false);

            palindrome.palindrome = forward;
            palindrome.numberOfAdditions = i;
            return palindrome;
        }

        public string[] ReadFromFile(string fileName)
        {
            string[] result;
            result = System.IO.File.ReadAllLines(fileName);

            return result;
        }

        public void PrintPalindrome(Palindrome palindrome)
        {
            Console.WriteLine(palindrome.numberOfAdditions + " " + palindrome.palindrome);
        }
    }
}
