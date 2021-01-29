Part 2 - A Few Good Methods
---

```cs
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
```

```cs
private static double GetAmount(string prompt)
{
   Console.Write(prompt);
   return double.Parse(Console.ReadLine());
} // end GetAmount( )
```

```cs
private static double GiveDenomination(double currentChangeDue, string label, double denomination)
{
   int count = (int) (currentChangeDue / denomination);
   Console.WriteLine($"{label}{count}");
   double newChangeDue = currentChangeDue % denomination;
   return newChangeDue;
} // end GiveDenomination( )
```

_**Shorter, but maybe less readable**_
```cs
private static double GiveDenomination(double currentChangeDue, string label, double denomination)
{
   Console.WriteLine($"{label}{(int) (currentChangeDue / denomination)}");
   return currentChangeDue % denomination;
} // end GiveDenomination( )
```

---

[Back](ReadMe.md)
| [Part 1](Part%201.md)
| **Part 2**
| [Part 3](Part%203.md)
| [Part 4](Part%204.md)
| [Part 5](Part%205.md)
| [Challenge](Challenge.md)
