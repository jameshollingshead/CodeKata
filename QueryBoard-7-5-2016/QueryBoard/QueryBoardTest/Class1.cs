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
        public void GetBoardAfterCreatingANewQueryBoardShouldReturnANewBoard()
        {
            var expectedResult = new int[256, 256];
            var actualResult = queryBoard.GetBoard();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CallingSetRowOnRow2ToSetValuesTo5ShouldCauseValuesAtRow2ToBe5()
        {
            var expectedResult = 5;
            queryBoard.SetRow(2, 5);
            var actualResult = queryBoard.GetBoard();

            for (int i = 0; i < 256; i++)
            {
                Assert.AreEqual(expectedResult, actualResult[2,i]);
            }
        }

        [Test]
        public void CallingSetColumnOnColumn2ToSetValuesTo5ShouldCauseValuesatColumn2ToBe5()
        {
            var expectedResult = 5;
            queryBoard.SetColumn(2, 5);
            var actualResult = queryBoard.GetBoard();

            for (int i = 0; i < 256; i++)
            {
                Assert.AreEqual(expectedResult, actualResult[i, 2]);
            }
        }

        [Test]
        public void SettingAColumnTo1AndThenCallingGetSumOfColumnOnThatColumnShouldReturn256()
        {
            var expectedResult = 256;
            queryBoard.SetColumn(2, 1);
            var actualResult = queryBoard.GetSumOfColumn(2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SettingColumn2To1AndRow2To2ThenCallingGetSumOfColumnOnColumn2ShouldReturn257()
        {
            var expectedResult = 257;
            queryBoard.SetColumn(2, 1);
            queryBoard.SetRow(2, 2);
            var actualResult = queryBoard.GetSumOfColumn(2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SettingARowTo1AndThenCallingGetSumOfRowOnThatRowShouldReturn256()
        {
            var expectedResult = 256;
            queryBoard.SetRow(2, 1);
            var actualResult = queryBoard.GetSumOfRow(2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SettingRow2To2AndColumn2To1ThenCallingGetSumOfRowOnRow2ShouldReturn257()
        {
            var expectedResult = 257;
            queryBoard.SetRow(2, 1);
            queryBoard.SetColumn(2, 2);
            var actualResult = queryBoard.GetSumOfRow(2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
