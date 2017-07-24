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

        
    }
}
