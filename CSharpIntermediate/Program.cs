using System;

namespace CSharpIntermediate
{
  class Program
  {
    static void Main(string[] args)
    {
      // Anatomy of a class: Data and Methods
      // Class Name
      // Data Names and types
      // Method Names

      // e.g.
      // Post
      // Title: string
      // Publish()

      // Object is an instance of a class that resides in memory


    }

    static void Users()
    {
      //Person bob = new Person("Bob", 36);
      var bob = Person.Parse("Bob");
      bob.Introduce("Sally");

      var customer = new Customer(1, "John");
      customer.Print();
      customer.NewOrder(1, 20.99);
    }

    static void UseParams()
    {
      Calculator calc = new Calculator();
      Console.WriteLine(calc.Add(1, 2));
      Console.WriteLine(calc.Add(1, 2, 3));
      Console.WriteLine(calc.Add(1, 2, 3, 4));
      Console.WriteLine(calc.Add(new int[] { 1, 2, 3, 4, 5 }));
    }
    static void UsePoints()
    {
      Point point = new Point(10, 20);
      try
      {
        point.Move(40, 60);
        point.GetPoint();
        point.Move(new Point(5, 10));
        point.GetPoint();
        point.Move(null);
      }
      catch (System.Exception)
      {
        Console.WriteLine("An unexpected error occured.");
      }

    }
  }
}
