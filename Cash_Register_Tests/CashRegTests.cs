using System;
using Cash_Register_Core;
using Xunit;

namespace Cash_Register_Tests {
    public class CashRegTests {

        private string Error (CashRegister cashRegister) =>
            $"The Error property != ERROR, but =  {cashRegister.ERROR}";

        private string ChangeCalculationError (decimal expected, decimal actual) =>
            $"Expected change: {expected} - Actual change: {actual}";

        private string ValuesAreNotEqualError =>
            "The input values were equal and the register did not return 0.";

        [Fact]
        public void Test1 () {
            var cashRegister = new CashRegister (15.94M, 16.00M);
            var change = cashRegister.CashToReturn ();
            Assert.True (change == 0.06M, ChangeCalculationError (0.06M, change));
        }

        [Fact]
        public void Test2 () {
            var cashRegister = new CashRegister (17M, 16M);
            Assert.True (cashRegister.ERROR == "ERROR", Error (cashRegister));
        }

        [Fact]
        public void Test3 () {
            var cashRegister = new CashRegister (35M, 35M);
            Assert.True (cashRegister.CashToReturn () == 0, ValuesAreNotEqualError);
        }

        [Fact]
        public void Test4 () {
            var cashRegister = new CashRegister (45M, 50M);
            var change = cashRegister.CashToReturn ();
            Assert.True (change == 5M, ChangeCalculationError (5M, change));
        }

        [Fact]
        public void Test5 () {
            var cashRegister = new CashRegister (24M, 29M);
            var change = cashRegister.CashToReturn ();
            Assert.True (change == 5M, ChangeCalculationError (5M, change));
        }
    }
}