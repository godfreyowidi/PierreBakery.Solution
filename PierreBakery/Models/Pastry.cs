using System.Collections.Generic;
using System;

namespace PierreBakery.Models
{
  public class PastryQuantity
  {
    public int Quantity;
    
    public PastryQuantity(int quantity)
    {
      Quantity = quantity;
    }

    public int CalcPastryCost(int quantity)
    {
      return quantity * 2;
    }
  }
}