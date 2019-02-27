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

        public String ViewDisplay()
        {
            string result;

            if (_hasDisplayBeenChecked)
            {
                result = GetInsertedCoinTotal();
            }
            else
            {
                result = IsThereAPriceToDisplay() ? GetPriceMessage() : GetInsertedCoinTotal();
            }
            ToggleHasDisplayBeenChecked();
            return result;
        }

        private string GetPriceMessage()
        {
            return _priceMessage;
        }

        private bool IsThereAPriceToDisplay()
        {
            return _priceMessage != string.Empty;
        }

        private string GetInsertedCoinTotal()
        {
            return AreCoinsAreInserted() ? ConvertMoneyToString(_coinBox.InsertedCoins()) : "Insert Coin";
        }

        private bool AreCoinsAreInserted()
        {
            return _coinBox.InsertedCoins() > 0;
        }

        private void ToggleHasDisplayBeenChecked()
        {
            _hasDisplayBeenChecked = !_hasDisplayBeenChecked;
        }

        private string ConvertMoneyToString(double money)
        {
            return "$" + string.Format("{0:0.00}", money);
        }

        public void InsertCoin(string coin)
        {
            if(_coinBox.IsValidCoin(coin))
                _coinBox.AddCoin(coin);
            else
                AddCoinToReturnedCoins(coin);
        }

        private void AddCoinToReturnedCoins(string coin)
        {
            _returnedCoins += _coinBox.GetCoinValue(coin);
        }

        public double CheckCoinReturn()
        {
            return GetReturnedCoinsTotal();
        }

        private double GetReturnedCoinsTotal()
        {
            return _returnedCoins;
        }

        public void OrderCola()
        {
            _priceMessage = "PRICE $1.00";
        }
    }
}
