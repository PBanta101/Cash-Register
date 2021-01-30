Challenge - Compute Denominations In Reverse Order
---

**Note**: This solution gives a reasonable solution, but not an optimal solution.

```cs
public static void Main(string[] args)
{
   double purchase = GetAmount("Purchase Amount: $ ");
   double payment  = GetAmount("Payment  Amount: $ ");

   while (payment < purchase)
   {
      Console.WriteLine("This payment isn't enough. Please re-enter.\n");
      purchase = GetAmount("Purchase Amount: $ ");
      payment  = GetAmount("Payment  Amount: $ ");
   }

   Console.WriteLine();

   if (payment == purchase)
   {
      Console.WriteLine("Exact Change. Thank You.");
   }
   else
   {
      double changeDue = payment - purchase + 0.001;
      Console.WriteLine($"     Change Due: $ {changeDue.ToString("N2")}\n");

      int changeInPennies = (int) (changeDue * 100.0);

      // Forward
      // changeDue = GiveDenomination(changeDue, "       Twenties: ", 20.00);
      // changeDue = GiveDenomination(changeDue, "           Tens: ", 10.00);
      // changeDue = GiveDenomination(changeDue, "          Fives: ",  5.00);
      // changeDue = GiveDenomination(changeDue, "           Ones: ",  1.00);
      // changeDue = GiveDenomination(changeDue, "       Quarters: ",  0.25);
      // changeDue = GiveDenomination(changeDue, "          Dimes: ",  0.10);
      // changeDue = GiveDenomination(changeDue, "        Nickels: ",  0.05);
      //             GiveDenomination(changeDue, "        Pennies: ",  0.01);

      // Reverse
      changeInPennies = GiveDenomination(changeInPennies, "        Pennies: ",    1,    5);
      changeInPennies = GiveDenomination(changeInPennies, "        Nickels: ",    5,   10);
      changeInPennies = GiveDenomination(changeInPennies, "          Dimes: ",   10,   25);
      changeInPennies = GiveDenomination(changeInPennies, "       Quarters: ",   25,  100);
      changeInPennies = GiveDenomination(changeInPennies, "           Ones: ",  100,  500);
      changeInPennies = GiveDenomination(changeInPennies, "          Fives: ",  500, 1000);
      changeInPennies = GiveDenomination(changeInPennies, "           Tens: ", 1000, 2000);
                        GiveDenomination(changeInPennies, "       Twenties: ", 2000      );
   }
} // end Main( )
```

```cs
private static double GetAmount(string prompt)
{
   double amount = 0.0;

   do
   {
      Console.Write(prompt);
      try
      {
         amount = double.Parse(Console.ReadLine());
         if (amount <= 0.0)
         {
            Console.WriteLine("The amount must be positive. Please re-enter.\n");
         }
      }
      catch (FormatException)
      {
         Console.WriteLine("This doesn't look like a number. Please re-enter.\n");
      }
   } while (amount <= 0.0);

   return amount;
} // end GetAmount( )
```

```cs
private static double GiveDenomination(double currentChangeDue, string label, double denomination)
{
   int count = (int) (currentChangeDue / denomination);

   if (count > 0)
   {
      Console.WriteLine($"{label}{count}");
   }

   return currentChangeDue % denomination;
} // end GiveDenomination( )
```

```cs
private static int GiveDenomination(int currentChangeDue, string label, int denomination)
{
   int count = currentChangeDue / denomination;

   if (count > 0)
   {
      Console.WriteLine($"{label}{count}");
   }

   return currentChangeDue % denomination;
} // end GiveDenomination( )
```

```cs
private static int GiveDenomination(int currentChangeDue, string label, int denom, int nextDenom)
{
   int amount = currentChangeDue % nextDenom;
   int count  = amount / denom;

   if (count > 0)
   {
      Console.WriteLine($"{label}{count}");
   }

   return currentChangeDue - amount;
} // end GiveDenomination( )
```

---

[Back](ReadMe.md)
| [Part 1](Part%201.md)
| [Part 2](Part%202.md)
| [Part 3](Part%203.md)
| [Part 4](Part%204.md)
| [Part 5](Part%205.md)
| **Challenge**
