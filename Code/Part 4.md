Part 4 - Loops
---

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

      changeDue = GiveDenomination(changeDue, "       Twenties: ", 20.00);
      changeDue = GiveDenomination(changeDue, "           Tens: ", 10.00);
      changeDue = GiveDenomination(changeDue, "          Fives: ", 5.00);
      changeDue = GiveDenomination(changeDue, "           Ones: ", 1.00);
      changeDue = GiveDenomination(changeDue, "       Quarters: ", 0.25);
      changeDue = GiveDenomination(changeDue, "          Dimes: ", 0.10);
      changeDue = GiveDenomination(changeDue, "        Nickels: ", 0.05);
                  GiveDenomination(changeDue, "        Pennies: ", 0.01);
   }
} // end Main( )
```

```cs
private static double GetAmount(string prompt)
{
   Console.Write(prompt);
   double amount = double.Parse(Console.ReadLine());

   while (amount <= 0.0)
   {
      Console.WriteLine("The amount must be positive. Please re-enter.\n");
      Console.Write(prompt);
      amount = double.Parse(Console.ReadLine());
   }

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

---

[Back](ReadMe.md)
| [Part 1](Part%201.md)
| [Part 2](Part%202.md)
| [Part 3](Part%203.md)
| **Part 4**
| [Part 5](Part%205.md)
| [Challenge](Challenge.md)
