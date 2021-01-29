Part 1 - One Big `Main()`
---

```cs
public static void Main(string[] args)
{
   Console.Write("Purchase Amount: $ ");
   double purchase = double.Parse(Console.ReadLine());

   Console.Write("Payment  Amount: $ ");
   double payment = double.Parse(Console.ReadLine());

   double changeDue = payment - purchase + 0.001;
   Console.WriteLine($"     Change Due: $ {changeDue.ToString("N2")}\n");

   Console.WriteLine($"       Twenties: {(int)(changeDue / 20.00)}");
   changeDue %= 20.00;

   Console.WriteLine($"           Tens: {(int)(changeDue / 10.00)}");
   changeDue %= 10.00;

   Console.WriteLine($"          Fives: {(int)(changeDue / 5.00)}");
   changeDue %= 5.00;

   Console.WriteLine($"           Ones: {(int)(changeDue / 1.00)}");
   changeDue %= 1.00;

   Console.WriteLine($"       Quarters: {(int)(changeDue / 0.25)}");
   changeDue %= 0.25;

   Console.WriteLine($"          Dimes: {(int)(changeDue / 0.10)}");
   changeDue %= 0.10;

   Console.WriteLine($"        Nickels: {(int)(changeDue / 0.05)}");
   changeDue %= 0.05;

   Console.WriteLine($"        Pennies: {(int)(changeDue / 0.01)}");
}
```

---

[Back](ReadMe.md)
| **Part 1**
| [Part 2](Part%202.md)
| [Part 3](Part%203.md)
| [Part 4](Part%204.md)
| [Part 5](Part%205.md)
| [Challenge](Challenge.md)
