using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Anatomy of a class: Data and Methods
            // Class Name
            // Data Names and types
            // Method Names

            // e.g.
            // Post
            // Title: string
            // Publish()

            // Object is an instance of a class that resides in memory

            Person bob = new Person("bob", 36);
            bob.Introduce();
        }
    }
}
