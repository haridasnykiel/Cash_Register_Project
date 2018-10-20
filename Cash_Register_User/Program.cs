using System;
using Cash_Register_Core;
namespace Cash_Register_User {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("\nWelcome to the Cash Register Program");
            Console.WriteLine ("\n\n====================================");
            Console.WriteLine ("\nInput Price of item.");
            decimal price = Convert.ToDecimal (Console.ReadLine ());
            Console.WriteLine ("\nInput customer cash.");
            Console.WriteLine ("\n====================================");
            decimal cash = Convert.ToDecimal (Console.ReadLine ());

            var cashRegister = new CashRegister (price, cash);
            if (price > cash)
                Console.WriteLine (cashRegister.ERROR);
            else {
                Console.WriteLine ("Cash to return: " + cashRegister.CashToReturn ().ToString ());
                Console.WriteLine ("\n\nChange: \n" + cashRegister.CalculateChange ());

            }

        }
    }
}