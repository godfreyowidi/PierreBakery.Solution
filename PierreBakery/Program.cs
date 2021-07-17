using PierreBakery.Models;
using System;

public class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Would you like to order bread or pastry? bread is $5 and pastry is $2 ");
    Console.WriteLine("bread is $5 or you can buy 2 and get 1 free!");
    Console.WriteLine("pastry is $2, or 3 for $5.");
    Console.WriteLine("How many bread would you like to order?");
    int bread = int.Parse(Console.ReadLine());
    Console.WriteLine($"{bread} How many pastries would you like to order?");
    int pastry = int.Parse(Console.ReadLine());

    BreadQuantity Order1 = new BreadQuantity(bread);
    PastryQuantity Order2 = new PastryQuantity(pastry);

    Console.WriteLine($"Your order is {bread} bread, {pastry} pastries");
    Console.WriteLine($"Checkout ${Order1.CalcBreadCost(bread) + Order2.CalcPastryCost(pastry)}");
  }
}