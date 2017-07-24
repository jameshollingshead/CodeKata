using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VendingMachines;


namespace VendingMachineTest
{
    [TestFixture]
    class VendingMachineUnitTests
    {
        public VendingMachine VendingMachine;
        public const string InsertCoin = "Insert Coin";
        public const string Penny = "Penny";
        public const string Nickel = "Nickel";
        public const string Dime = "Dime";
        public const string Quarter = "Quarter";

        [SetUp]
        public void TestSetup()
        {
            VendingMachine = new VendingMachine();
        }

        [Test]
        public void LookingAtDisplayWithNoCoinsInsertedShouldSayInsertCoin()
        {
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual(InsertCoin, result);
        }

        [Test]
        public void WhenADimeIsInsertedTheDisplayWillRead10Cents()
        {
            VendingMachine.InsertCoin(Dime);
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual("$0.10", result);
        }

        [Test]
        public void WhenANickelIsInsertedDisplayWillRead5Cents()
        {
            VendingMachine.InsertCoin(Nickel);
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual("$0.05", result);
        }

        [Test]
        public void WhenAQuarterIsInsertedDisplayWillRead25Cents()
        {
            VendingMachine.InsertCoin(Quarter);
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual("$0.25", result);
        }

        [Test]
        public void WhenAPennyIsInsertedDisplayWillReadInsertCoin()
        {
            VendingMachine.InsertCoin(Penny);
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual(InsertCoin, result);
        }

        [Test]
        public void WhenAPennyIsInsertedCoinReturnWillContain1Cent()
        {
            VendingMachine.InsertCoin(Penny);
            var result = VendingMachine.GetReturnedCoins();
            Assert.AreEqual(0.01, result);
        }

        [Test]
        public void WhenTwoPenniesAreInsertedCoinReturnWillContain2Cents()
        {
            VendingMachine.InsertCoin(Penny);
            VendingMachine.InsertCoin(Penny);
            var result = VendingMachine.GetReturnedCoins();
            Assert.AreEqual(0.02, result);
        }

        [Test]
        public void WhenADimeAndANickelAreInsertedDisplayWillRead15Cents()
        {
            VendingMachine.InsertCoin(Dime);
            VendingMachine.InsertCoin(Nickel);
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual("$0.15", result);
        }

        [Test]
        public void WhenADimeAndAQuarterAreInsertedDisplayWillRead35Cents()
        {
            VendingMachine.InsertCoin(Dime);
            VendingMachine.InsertCoin(Quarter);
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual("$0.35", result);
        }

        [Test]
        public void WhenTheColaButtonIsPressedWithoutMoneyInsertedThePriceOfTheColaWillBeDisplayed()
        {
            VendingMachine.OrderCola();
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual("PRICE $1.00", result);
        }

        [Test]
        public void WhenTheColaButtonIsPressedWithoutMoneyAndDisplayIsCheckTwiceInsertedInsertCoinWillBeDisplayed()
        {
            VendingMachine.OrderCola();
            var result = VendingMachine.GetDisplay();
            result = VendingMachine.GetDisplay();
            Assert.AreEqual(InsertCoin, result);
        }
    }
}
