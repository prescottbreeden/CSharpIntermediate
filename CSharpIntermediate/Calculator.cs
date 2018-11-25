namespace CSharpIntermediate
{
  class Calculator
  {
    private int total {get; set;}
    public Calculator() 
    { 
      total = 0;
    }
    public int Add(params int[] numbers) 
    { 
      total = 0;
      foreach (int num in numbers) {
        total += num;
      }
      return total;
    }
  }
}
