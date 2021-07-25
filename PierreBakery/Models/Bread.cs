using System.Collections.Generic;
using System;

namespace PierreBakery.Models
{
  public class BreadQuantity
  {
    
    public int Quantity { get; set; }

    public BreadQuantity(int quantity)
    {
      Quantity = quantity;
    }
    public int CalcBreadCost(int quantity)
    {
      int totalCost = (quantity * 5) - ((quantity / 3) * 5);
      return totalCost;      
    }
  }
}