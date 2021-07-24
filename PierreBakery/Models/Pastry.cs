using System.Collections.Generic;
using System;

namespace PierreBakery.Models
{
  public class PastryQuantity
  {
    public int Quantity { get; set; }
    
    public PastryQuantity(int quantity)
    {
      Quantity = quantity;
    }

    public int CalcPastryCost(int quantity)
    {
      int totalCost = ((quantity * 2) - (quantity / 3)); 
      return totalCost;
    }
  }
}