using System;

namespace CSharpIntermediate
{
  public class Point
  {
    private int X { get; set; }
    private int Y { get; set; }

    public Point(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }

    public void Move(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }

    public void Move(Point newLocation)
    {
      // this.X = newLocation.X;
      // this.Y = newLocation.Y;
      // repetitive, can just called the first method instead

      if (newLocation == null)
        throw new ArgumentNullException("newLocation", "Points cannot be null.");

      Move(newLocation.X, newLocation.Y);
    }

    public void GetPoint() 
    {
      System.Console.WriteLine("X: {0}, Y: {1}", X, Y);
    }
  }
}
