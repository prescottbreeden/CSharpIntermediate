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

            //Person bob = new Person("Bob", 36);
            var bob = Person.Parse("Bob");
            bob.Introduce("Sally");

            var customer = new Customer(1, "John");
            customer.Print();
            customer.NewOrder(1, 20.99);
        }
    }
}
