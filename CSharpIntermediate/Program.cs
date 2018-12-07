using System;
using NUnit.Framework;
using NUnit.Framework.Tests;

namespace CSharpIntermediate
{
  partial class Program
  {
    static void Main(string[] args)
    {

    }
    public static void ImplementExtendedInterface()
    {
      // var dbMigrator = new DbMigrator(new ConsoleLogger());
      var dbMigrator = new DbMigrator(new FileLogger("./log.txt"));
      dbMigrator.Migrate();
    }
    public static void CreateOrder() 
    {
      var orderProcessor = new OrderProcessor(new ShippingCalculator());
      var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
      orderProcessor.Process(order);

      OrderProcessorTests test = new OrderProcessorTests();

      test.Process_OrderIsAlreadyShippinged_ThrowsAnException();
    }
    public static void Points()
    {
      var point = new Point(10, 20);
      Console.WriteLine(point);
      point.Move(new Point(40, 60));
      Console.WriteLine(point);
      point.Move(100, 200);
      Console.WriteLine(point);
    }

    public static void Stuff()
    {
      //Person bob = new Person("Bob", 36);
      var bob = Person.Parse("Bob");
      bob.SetBirthdate(new DateTime(1982, 1, 1));
      Console.WriteLine(bob.GetBirthdate());
      bob.Introduce("Sally");

      var customer = new Customer(1, "John");
      customer.Print();
      customer.NewOrder(1, 20.99f);
    }

    public static void Calc()
    {
      Calculator calc = new Calculator();
      Console.WriteLine(calc.Add(1, 2, 3, 4, 5));
      Console.WriteLine(calc.Add(new int[] { 1, 2, 3, 4, 5 }));
    }
  }
}

