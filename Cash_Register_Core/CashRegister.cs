using System;

namespace Cash_Register_Core {
    public class CashRegister {

        public const decimal PENNY = 00.01M;
        public const decimal NICKEL = 00.05M;
        public const decimal DIME = 00.10M;
        public const decimal QUARTER = 00.25M;
        public const decimal HALF_DOLLAR = 00.50M;
        public const decimal ONE = 01.00M;
        public const decimal TWO = 02.00M;
        public const decimal FIVE = 05.00M;
        public const decimal TEN = 10.00M;
        public const decimal TWENTY = 20.00M;
        public const decimal FIFTY = 50.00M;
        public const decimal ONE_HUNDRED = 100.00M;

        private decimal _price;
        private decimal _cash;

        public CashRegister (decimal price, decimal cash) {
            _price = price;
            _cash = cash;
        }

        public string ERROR {
            get {
                return _price > _cash ? "ERROR" : null;
            }
        }

        public decimal CashToReturn () {
            if (_price == _cash) {
                return 0M;
            } else {
                return 10.00M;
            }
        }

    }
}