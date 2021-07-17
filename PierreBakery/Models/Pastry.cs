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
      if (quantity % 3 == 0)
      {
        int totalCost = ((quantity / 3) * 5);
        return totalCost;
      }
      else
      {
        return quantity * 2;
      }
    }
  }
}