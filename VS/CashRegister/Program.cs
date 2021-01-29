using System;

namespace CashRegister
{
   class Program
   {
      public static void Main(string[] args)
      {
         double purchase = GetAmount("Purchase Amount: $ ");
         double payment  = GetAmount("Payment  Amount: $ ");

         double changeDue = payment - purchase + 0.001;
         Console.WriteLine($"     Change Due: $ {changeDue.ToString("N2")}\n");

         changeDue = GiveDenomination(changeDue, "       Twenties: ", 20.00);
         changeDue = GiveDenomination(changeDue, "           Tens: ", 10.00);
         changeDue = GiveDenomination(changeDue, "          Fives: ",  5.00);
         changeDue = GiveDenomination(changeDue, "           Ones: ",  1.00);
         changeDue = GiveDenomination(changeDue, "       Quarters: ",  0.25);
         changeDue = GiveDenomination(changeDue, "          Dimes: ",  0.10);
         changeDue = GiveDenomination(changeDue, "        Nickels: ",  0.05);
                     GiveDenomination(changeDue, "        Pennies: ",  0.01);
      } // end Main( )

      private static double GetAmount(string prompt)
      {
         Console.Write(prompt);
         return double.Parse(Console.ReadLine());
      } // end GetAmount( )

      private static double GiveDenomination(double currentChangeDue, string label, double denomination)
      {
         Console.WriteLine($"{label}{(int)(currentChangeDue / denomination)}");
         return currentChangeDue % denomination;
      } // end GiveDenomination( )
   }
}
