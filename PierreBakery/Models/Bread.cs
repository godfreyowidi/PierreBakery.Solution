using System.Collections.Generic;
using System;

namespace PierreBakery.Models
{
  public class BreadQuantity
  {
    
    public int Quantity;

    public BreadQuantity(int quantity)
    {
      Quantity = quantity;
    }

    public int CalcBreadCost(int quantity)
    {
      return quantity;
    }
  }
}