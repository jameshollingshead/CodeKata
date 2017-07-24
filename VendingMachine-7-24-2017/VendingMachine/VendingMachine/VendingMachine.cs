using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines
{
    public class VendingMachine
    {
        private double insertedCoins = 0.0;
        private double returnedCoins = 0.0;
        private string priceMessage = string.Empty;
        private bool hasDisplayBeenChecked = false;
        private readonly CoinBox _coinBox = new CoinBox();

        public VendingMachine()
        {
            
        }

        public String GetDisplay()
        {
            if (hasDisplayBeenChecked)
            {
                ToggleHasDisplayBeenChecked();
                if (insertedCoins == 0) return "Insert Coin";
                else return ConvertMoneyToString();
            }
            else
            {
                ToggleHasDisplayBeenChecked();
                if (priceMessage != string.Empty)
                    return priceMessage;
                if (insertedCoins == 0) return "Insert Coin";
                else return ConvertMoneyToString();
            }
            
        }

        private void ToggleHasDisplayBeenChecked()
        {
            hasDisplayBeenChecked = !hasDisplayBeenChecked;
        }

        private string ConvertMoneyToString()
        {
            return "$" + string.Format("{0:0.00}", insertedCoins);
        }

        public void InsertCoin(string coin)
        {
            if(_coinBox.IsValidCoin(coin))
                insertedCoins = _coinBox.AddCoinToInsertedCoins(coin, insertedCoins);
            else
                returnedCoins = _coinBox.AddCoinToReturnedCoins(coin, returnedCoins);
        }

        public double GetReturnedCoins()
        {
            return returnedCoins;
        }

        public void OrderCola()
        {
            priceMessage = "PRICE $1.00";
        }
    }
}
