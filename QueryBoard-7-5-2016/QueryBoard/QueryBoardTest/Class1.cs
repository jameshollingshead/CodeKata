using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using QueryBoard;

namespace QueryBoard.Test
{
    [TestFixture]
    public class UnitTests
    {
        public QueryBoard queryBoard;

        [SetUp]
        public void TestSetup()
        {
            queryBoard = new QueryBoard();
        }

        [Test]
        public void CreateBoardShouldCreateANewBoard()
        {
            var expectedResult = new int[256, 256];
            var actualResult = queryBoard.CreateBoard();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
