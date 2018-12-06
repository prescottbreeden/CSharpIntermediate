namespace CSharpIntermediate
{
  public class FakeShippingCalculator : IShippingCalculator
  {
    public float CalculateShipping(Order order)
    {
      return 1;
    }
  }
}
