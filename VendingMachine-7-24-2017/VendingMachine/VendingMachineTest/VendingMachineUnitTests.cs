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
        public const string DimeInserted = "$0.10";

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
        public void WhenADimeIsInsertedTheDisplayWillSayThereAre10Cents()
        {
            VendingMachine.InsertCoin("Dime");
            var result = VendingMachine.GetDisplay();
            Assert.AreEqual(DimeInserted, result);
        }

        
    }
}
