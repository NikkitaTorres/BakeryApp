namespace BakeryApp.Models
{
  public class Bread
  {
    public int Quantity { get; set; }

    public int CalculateBreadCost()
    {
      int paidLoaves = Quantity - Quantity / 3;
      
      int totalCost = paidLoaves * 5;

      return totalCost;
    }
  }
}