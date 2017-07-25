using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachines
{
    public class VendingMachine
    {
        private double _insertedCoins = 0.0;
        private double _returnedCoins = 0.0;
        private string _priceMessage = string.Empty;
        private bool _hasDisplayBeenChecked = false;
        private readonly CoinBox _coinBox = new CoinBox();

        public String GetDisplay()
        {
            if (_hasDisplayBeenChecked)
            {
                ToggleHasDisplayBeenChecked();
                return GetTotalInsertedCoins();
            }
            else
            {
                ToggleHasDisplayBeenChecked();
                if (IsThereAPriceToDisplay())
                    return GetPriceMessage();
                return GetTotalInsertedCoins();
            }
        }

        private string GetPriceMessage()
        {
            return _priceMessage;
        }

        private bool IsThereAPriceToDisplay()
        {
            return _priceMessage != string.Empty;
        }

        private string GetTotalInsertedCoins()
        {
            return AreCoinsAreInserted() ? ConvertMoneyToString() : "Insert Coin";
        }

        private bool AreCoinsAreInserted()
        {
            return _insertedCoins > 0;
        }

        private void ToggleHasDisplayBeenChecked()
        {
            _hasDisplayBeenChecked = !_hasDisplayBeenChecked;
        }

        private string ConvertMoneyToString()
        {
            return "$" + string.Format("{0:0.00}", _insertedCoins);
        }

        public void InsertCoin(string coin)
        {
            if(_coinBox.IsValidCoin(coin))
                AddCoinToInsertedCoins(coin);
            else
                AddCoinToReturnedCoins(coin);
        }

        private void AddCoinToReturnedCoins(string coin)
        {
            _returnedCoins += _coinBox.GetCoinValue(coin);
        }

        private void AddCoinToInsertedCoins(string coin)
        {
            _insertedCoins += _coinBox.GetCoinValue(coin);
        }

        public double GetReturnedCoins()
        {
            return _returnedCoins;
        }

        public void OrderCola()
        {
            _priceMessage = "PRICE $1.00";
        }
    }
}
