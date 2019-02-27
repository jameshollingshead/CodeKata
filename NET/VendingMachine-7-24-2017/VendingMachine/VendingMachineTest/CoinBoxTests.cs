using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VendingMachines;

namespace VendingMachineTest
{
    class CoinBoxTests
    {
        private CoinBox _coinBox;
        private const string Penny = "Penny";
        private const string Nickel = "Nickel";
        private const string Dime = "Dime";
        private const string Quarter = "Quarter";
        private const double _precision = 0.001;

        [SetUp]
        public void TestSetup()
        {
            _coinBox = new CoinBox();
        }

        [Test]
        public void NickelIsAValidCoin()
        {
            Assert.IsTrue(_coinBox.IsValidCoin(Nickel));
        }

        [Test]
        public void DimeIsAValidCoin()
        {
            Assert.IsTrue(_coinBox.IsValidCoin(Dime));
        }

        [Test]
        public void QuarterIsAValidCoin()
        {
            Assert.IsTrue(_coinBox.IsValidCoin(Quarter));
        }

        [Test]
        public void PennyIsNotAValidCoin()
        {
            Assert.IsFalse(_coinBox.IsValidCoin(Penny));
        }

        [Test]
        public void PennyIsWorth1Cent()
        {
            Assert.AreEqual(0.01, _coinBox.GetCoinValue(Penny));
        }

        [Test]
        public void NickelIsWorth5Cents()
        {
            Assert.AreEqual(0.05, _coinBox.GetCoinValue(Nickel));
        }

        [Test]
        public void DimeIsWorth10Cents()
        {
            Assert.AreEqual(0.10, _coinBox.GetCoinValue(Dime));
        }

        [Test]
        public void QuarterIsWorth25Cents()
        {
            Assert.AreEqual(0.25, _coinBox.GetCoinValue(Quarter));
        }

        [Test]
        public void AddingANickleMakesCoinBoxInsertedCoinsEqual5Cents()
        {
            _coinBox.AddCoin(Nickel);
            Assert.AreEqual(0.05, _coinBox.InsertedCoins());
        }

        [Test]
        public void AddingANickleAndDimeMackesCoinBoxInsertedCoinsEqual15Cents()
        {
            _coinBox.AddCoin(Nickel);
            _coinBox.AddCoin(Dime);
            Assert.AreEqual(0.15, _coinBox.InsertedCoins(), _precision);
        }
    }
}
