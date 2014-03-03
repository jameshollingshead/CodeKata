using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ReverseAndAdd;


namespace ReverseAndAdd.UnitTests
{
    [TestFixture]
    public class ReverseAndAddTest
    {
        public ReverseAndAdd _reverseAndAdd;

        [SetUp]
        public void SetUpUnitTests()
        {
            _reverseAndAdd = new ReverseAndAdd();
        }

        [Test]
        public void Reverse123Gives321()
        {
            var forward = "123";
            var expectedResult = "321";
            var actualResult = _reverseAndAdd.ReverseString(forward);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Reverse957Gives759()
        {
            var forward = "957";
            var expectedResult = "759";
            var actualResult = _reverseAndAdd.ReverseString(forward);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adding123And321Gives444()
        {
            var forward = "123";
            var backward = "321";
            var expectedResult = "444";
            var actualResult = _reverseAndAdd.AddTwoNumberStrings(forward, backward);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adding777and345Gives1122()
        {
            var forward = "777";
            var backward = "345";
            var expectedResult = "1122";
            var actualResult = _reverseAndAdd.AddTwoNumberStrings(forward, backward);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number1234IsNotAPalindrome()
        {
            var palindromeCandidate = "1234";
            var expectedResult = false;
            var actualResult = _reverseAndAdd.IsPalindrome(palindromeCandidate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number134IsNotAPalindrome()
        {
            var palindromeCandidate = "134";
            var expectedResult = false;
            var actualResult = _reverseAndAdd.IsPalindrome(palindromeCandidate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number14IsNotAPalindrome()
        {
            var palindromeCandidate = "14";
            var expectedResult = false;
            var actualResult = _reverseAndAdd.IsPalindrome(palindromeCandidate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number1221IsAPalindrome()
        {
            var palindromeCandidate = "1221";
            var expectedResult = true;
            var actualResult = _reverseAndAdd.IsPalindrome(palindromeCandidate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number1IsAPalindrome()
        {
            var palindromeCandidate = "1";
            var expectedResult = true;
            var actualResult = _reverseAndAdd.IsPalindrome(palindromeCandidate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number11IsAPalindrome()
        {
            var palindromeCandidate = "11";
            var expectedResult = true;
            var actualResult = _reverseAndAdd.IsPalindrome(palindromeCandidate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number121IsAPalindrome()
        {
            var palindromeCandidate = "121";
            var expectedResult = true;
            var actualResult = _reverseAndAdd.IsPalindrome(palindromeCandidate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Number123Has444AsAPalindromeIn1Addition()
        {
            var expectedResult = new Palindrome();
            expectedResult.palindrome = "444";
            expectedResult.numberOfAdditions = 1;
            var input = "123";
            var actualResult = _reverseAndAdd.FindPalindrome(input);
            Assert.AreEqual(expectedResult.palindrome, actualResult.palindrome);
            Assert.AreEqual(expectedResult.numberOfAdditions, actualResult.numberOfAdditions);
        }

        [Test]
        public void Number195Has9339AsAPalindromeIn4Additions()
        {
            var expectedResult = new Palindrome();
            expectedResult.palindrome = "9339";
            expectedResult.numberOfAdditions = 4;
            var input = "195";
            var actualResult = _reverseAndAdd.FindPalindrome(input);
            Assert.AreEqual(expectedResult.palindrome, actualResult.palindrome);
            Assert.AreEqual(expectedResult.numberOfAdditions, actualResult.numberOfAdditions);
        }

        [Test]
        public void ReadFromFileShouldGive123_111_195()
        {
            string[] expectedResult = {"123", "111", "195"};
            var fileName = "testfile.txt";
            string[] actualResult = _reverseAndAdd.ReadFromFile(fileName);
            
            Assert.AreEqual(expectedResult[0], actualResult[0]);
            Assert.AreEqual(expectedResult[1], actualResult[1]);
            Assert.AreEqual(expectedResult[2], actualResult[2]);
        }
        
    }

    
}
