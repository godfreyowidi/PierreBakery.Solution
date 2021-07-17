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
      if(quantity % 2 == 0)
      {
        int totalCost = ((quantity / 2) * 5);
        return totalCost;
      }
      else
      {
      return quantity * 5;
      }
    }
  }
}