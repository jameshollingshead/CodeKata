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
        private VendingMachine VendingMachine;
        private const string InsertCoin = "Insert Coin";
        private const string Penny = "Penny";
        private const string Nickel = "Nickel";
        private const string Dime = "Dime";
        private const string Quarter = "Quarter";

        [SetUp]
        public void TestSetup()
        {
            VendingMachine = new VendingMachine();
        }

        [Test]
        public void LookingAtDisplayWithNoCoinsInsertedShouldSayInsertCoin()
        {
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual(InsertCoin, result);
        }

        [Test]
        public void WhenADimeIsInsertedTheDisplayWillRead10Cents()
        {
            VendingMachine.InsertCoin(Dime);
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual("$0.10", result);
        }

        [Test]
        public void WhenANickelIsInsertedDisplayWillRead5Cents()
        {
            VendingMachine.InsertCoin(Nickel);
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual("$0.05", result);
        }

        [Test]
        public void WhenAQuarterIsInsertedDisplayWillRead25Cents()
        {
            VendingMachine.InsertCoin(Quarter);
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual("$0.25", result);
        }

        [Test]
        public void WhenAPennyIsInsertedDisplayWillReadInsertCoin()
        {
            VendingMachine.InsertCoin(Penny);
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual(InsertCoin, result);
        }

        [Test]
        public void WhenAPennyIsInsertedCoinReturnWillContain1Cent()
        {
            VendingMachine.InsertCoin(Penny);
            var result = VendingMachine.CheckCoinReturn();
            Assert.AreEqual(0.01, result);
        }

        [Test]
        public void WhenTwoPenniesAreInsertedCoinReturnWillContain2Cents()
        {
            VendingMachine.InsertCoin(Penny);
            VendingMachine.InsertCoin(Penny);
            var result = VendingMachine.CheckCoinReturn();
            Assert.AreEqual(0.02, result);
        }

        [Test]
        public void WhenADimeAndANickelAreInsertedDisplayWillRead15Cents()
        {
            VendingMachine.InsertCoin(Dime);
            VendingMachine.InsertCoin(Nickel);
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual("$0.15", result);
        }

        [Test]
        public void WhenADimeAndAQuarterAreInsertedDisplayWillRead35Cents()
        {
            VendingMachine.InsertCoin(Dime);
            VendingMachine.InsertCoin(Quarter);
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual("$0.35", result);
        }

        [Test]
        public void WhenTheColaButtonIsPressedWithoutMoneyInsertedThePriceOfTheColaWillBeDisplayed()
        {
            VendingMachine.OrderCola();
            var result = VendingMachine.ViewDisplay();
            Assert.AreEqual("PRICE $1.00", result);
        }

        [Test]
        public void WhenTheColaButtonIsPressedWithoutMoneyAndDisplayIsCheckTwiceInsertedInsertCoinWillBeDisplayed()
        {
            VendingMachine.OrderCola();
            var result = VendingMachine.ViewDisplay();
            result = VendingMachine.ViewDisplay();
            Assert.AreEqual(InsertCoin, result);
        }
    }
}
