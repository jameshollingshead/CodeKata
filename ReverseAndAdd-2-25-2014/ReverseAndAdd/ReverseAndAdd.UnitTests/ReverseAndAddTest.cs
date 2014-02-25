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
            var actualResult = _reverseAndAdd.ReverseNumberAsString(forward);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Reverse957Gives759()
        {
            var forward = "957";
            var expectedResult = "759";
            var actualResult = _reverseAndAdd.ReverseNumberAsString(forward);
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
    }

    
}
