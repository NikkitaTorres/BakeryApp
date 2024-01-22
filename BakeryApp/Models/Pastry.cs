namespace BakeryApp.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public int CalculateTotalCost()
    {
      int paidLoaves = Quantity - Quantity / 3;
      
      int totalCost = paidLoaves * 2;

      return totalCost;
    }
  }
}