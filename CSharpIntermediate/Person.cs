namespace CSharpIntermediate
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            System.Console.WriteLine("Hi, my name is " + Name);
        }

    }
}
