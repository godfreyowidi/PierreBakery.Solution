using PierreBakery.Models;
using System;

public class Program
{
  static void Main()
  {
    try
    {
      Console.WriteLine("           / |");
      Console.WriteLine("          /  |");
      Console.WriteLine("         /   |");
      Console.WriteLine("        /    |");
      Console.WriteLine("       /     |");
      Console.WriteLine("      /      |");
      Console.WriteLine("     /       |");
      Console.WriteLine("    /        |");
      Console.WriteLine("   / Welcome |");
      Console.WriteLine("  /    To    |");
      Console.WriteLine(" /           |");
      Console.WriteLine("/PierreBakery|");
      Console.WriteLine("-------------");
      Console.WriteLine("Would you like to order bread or pastry? bread is $5 and pastry is $2 ");
      Console.WriteLine("bread is $5 or you can buy 2 and get 1 free!");
      Console.WriteLine("pastry is $2, or 3 for $5.");
      Console.WriteLine("How many bread would you like to order?");
      int bread = int.Parse(Console.ReadLine());
      Console.WriteLine($"{bread} How many pastries would you like to order?");
      int pastry = int.Parse(Console.ReadLine());

      BreadQuantity Order1 = new BreadQuantity(bread);
      PastryQuantity Order2 = new PastryQuantity(pastry);

      int breadDiscount = bread % 2;
      int pastryDiscount = pastry % 3;
      if(breadDiscount > 0 || pastryDiscount > 0)
      {
        Console.WriteLine($"Your order is {bread} bread, {pastry} pastries. You get {breadDiscount} bread and {pastryDiscount} pastries as discount totally free!");
      }
      else
      {
        Console.WriteLine($"Your order is {bread} bread, {pastry} pastries");  
      }
      
      Console.WriteLine($"Checkout: ${Order1.CalcBreadCost(bread) + Order2.CalcPastryCost(pastry)}");
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
    }
  }
}