using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Points();
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
            bob.Introduce("Sally");

            var customer = new Customer(1, "John");
            customer.Print();
            customer.NewOrder(1, 20.99);
        }

        public static void Calc()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calc.Add(new int[] { 1, 2, 3, 4, 5 } ));
        }
    }
}
