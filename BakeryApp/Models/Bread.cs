namespace BakeryApp.Models
{
  public class Bread
  {
    public int Quantity { get; set; }

    public int CalculateTotalCost()
    {
      int paidLoaves = Quantity - Quantity / 3;
      
      int totalCost = paidLoaves * 5;

      return totalCost;
    }
  }
}


// 3 - 3/3
// 2 * 5
// 10

// 10 - 10/3
// 10 - 3.33333
// 6.66667 * 5?

//7*5 35